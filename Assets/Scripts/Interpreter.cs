// unitycoder.com

using UnityEngine;
using System.Collections;
using MoonSharp.Interpreter;
using Lua;

#if UNITY_EDITOR
using MoonSharp.Interpreter.Serialization; // needed for DUMP
#endif

[DefaultExecutionOrder(-50)]
public class Interpreter : MonoBehaviour
{
    Script scriptEngine;
    public static Interpreter instance;

#if UNITY_EDITOR
    public bool makeDump = false;
#endif

    void Awake()
    {
        if (instance != null) DestroyImmediate(gameObject);
        instance = this;

        // reference dumped code, so it doesnt get stripped
        MyNamespace.MyClass.Initialize();
    }

    void Start()
    {
        UserData.RegisterAssembly();
        scriptEngine = new Script();
        // register custom type converters
        Script.GlobalOptions.CustomConverters.SetClrToScriptCustomConversion<Color32>((_s, v) => DynValue.NewString(v.r + "," + v.g + "," + v.b + "," + v.a)); // temporary color32 converter to string
        Script.GlobalOptions.CustomConverters.SetClrToScriptCustomConversion<Vector3>((_s, v) => DynValue.NewString(v.x + "," + v.y + "," + v.z)); // temporary vector3 converter to string
        //This here is the function we need to set the type to be able to instantiate. I know, it's global, but it lets us use
        //the methods and UnityEngine functions with ease from Lua.
        scriptEngine.Globals.Set("LuaAPI", UserData.Create(ScriptableObject.CreateInstance(typeof(LuaAPI))));

        // make hardwire dump (otherwise stuff get stripped on build)
        // then call moonsharp to generate c# class https://www.moonsharp.org/hardwire.html
#if UNITY_EDITOR
        if (makeDump)
        {
            Table dump = UserData.GetDescriptionOfRegisteredTypes(true);
            print(Application.dataPath + "/testdump.lua");
            System.IO.File.WriteAllText(Application.dataPath + "/testdump.lua", dump.Serialize());
        }
#endif
    }

    // sample methods to run code
    public void Execute(string scriptString)
    {
        Run(scriptString);
    }

    public void ExecuteRawScript(string rawString)
    {
        // skip nulls
        if (string.IsNullOrEmpty(rawString))
        {
            Debug.LogError("ExecuteRawScript got null..");
            return;
        }
        // fix pipes
        var scriptString = rawString.Replace("@", "|");
        Run(scriptString);
    }

    public IEnumerator LoadAndRunRawScript(string rawLuaURL)
    {
        WWW www = new WWW(rawLuaURL);
        yield return www;

        if (!string.IsNullOrEmpty(www.error))
        {
            Debug.Log(www.error);
        }
        else // no error
        {
            Run(www.text);
        }
    }

    public void Run(string scriptString)
    {
        DynValue function = scriptEngine.DoString(scriptString);

        // check if we got function to iterate over
        if (function == DynValue.Void)
        {
            // TODO: but maybe other script still want to run?
            runUpdateLoop = false;
            StopAllCoroutines();

            // TODO: could get function name as a string, then attach that string to the gaze event, which then runs the function?
            // test getting some fixed name function and use that on events?
            //            DynValue luaFactFunction = scriptEngine.Globals.Get("OnClick");
            //            Debug.Log(luaFactFunction);
            //          if (luaFactFunction != DynValue.Void && luaFactFunction != DynValue.Nil)
            //        {
            //          DynValue res = scriptEngine.Call(luaFactFunction);
            //        Debug.Log(res);
            //  }
        }
        else
        {
            coroutine = scriptEngine.CreateCoroutine(function);
            // cleanup?
            runUpdateLoop = false;
            StopAllCoroutines();
            runUpdateLoop = true;
            StartCoroutine(LuaLoop());
        }

    }

    DynValue coroutine;
    bool runUpdateLoop = false;

    /// <summary>
    /// coroutine loop for running LUA endless-loops
    /// </summary>
    /// <returns></returns>
    IEnumerator LuaLoop()
    {
        // delay per function call
        float loopDelayTime = 0.16f;
        var delay = new WaitForSeconds(loopDelayTime);

        while (runUpdateLoop)
        {
            // TODO: check if can resume or not
            DynValue x = coroutine.Coroutine.Resume();

            // check for delay value
            if (x != DynValue.Nil)
            {
                var newDelay = (float)x.CastToNumber();
                if (!Mathf.Approximately(loopDelayTime, newDelay))
                {
                    newDelay = Mathf.Clamp(newDelay, 0.01f, 99999f);
                    delay = new WaitForSeconds(newDelay);
                }
            }
            yield return delay;
        }
    }

    /// <summary>
    /// stops lua coroutine and clears objects
    /// </summary>
    public void StopLua()
    {
        //        Debug.Log("StopLua");
        runUpdateLoop = false;
        StopAllCoroutines();

        // delete objects
        //BinooTools.instance.ClearOldModels(transform);
    }

    /// <summary>
    /// callback for running custom functions (from object click for example)
    /// </summary>
    /// <param name="functionName"></param>
    public void RunFunction(string functionName)
    {
        DynValue luaFactFunction = scriptEngine.Globals.Get(functionName);
        if (luaFactFunction != DynValue.Void && luaFactFunction != DynValue.Nil)
        {
            DynValue res = scriptEngine.Call(luaFactFunction);
            //            Debug.Log("dynval:" + res);
        }
        else
        {
            Debug.LogWarning("LUA Function doesnt exist:" + functionName);
        }
    }

    public void RunFunction(string functionName, string target)
    {
        DynValue luaFactFunction = scriptEngine.Globals.Get(functionName);
        if (luaFactFunction != DynValue.Void && luaFactFunction != DynValue.Nil)
        {
            DynValue res = scriptEngine.Call(luaFactFunction, target);
            //Debug.Log(res);
        }
        else
        {
            Debug.LogError("LUA Function doesnt exist:" + functionName);
        }
    }

    public void RunFunction(string functionName, string target, string param)
    {
        // no param
        if (string.IsNullOrEmpty(param))
        {
            RunFunction(functionName, target);
            return;
        }

        DynValue luaFactFunction = scriptEngine.Globals.Get(functionName);
        if (luaFactFunction != DynValue.Void && luaFactFunction != DynValue.Nil)
        {
            DynValue res = scriptEngine.Call(luaFactFunction, target, param);
            //            Debug.Log(res);
        }
        else
        {
            Debug.LogError("LUA Function doesnt exist:" + functionName);
        }
    }


}