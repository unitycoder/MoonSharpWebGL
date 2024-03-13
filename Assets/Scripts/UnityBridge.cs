// unitycoder.com
// this method is called from c# or UI, and it calls the interpreter to run the code

using UnityEngine;
using UnityEngine.UI;

[DefaultExecutionOrder(-100)]
public class UnityBridge : MonoBehaviour
{
    public static UnityBridge instance;
    public Material defaultMaterial;

    void Awake()
    {
        if (instance != null) DestroyImmediate(gameObject);
        instance = this;
    }

    // called from UI button
    public void Execute(InputField src)
    {
        Interpreter.instance.Run(src.text);
    }

}
