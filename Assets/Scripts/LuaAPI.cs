// unitycoder.com
// these c# methods are called from Lua script

using MoonSharp.Interpreter;
using UnityEngine;

namespace Lua
{
    [MoonSharpUserData]
    public class LuaAPI : ScriptableObject
    {
        public void CreateSphere(string newName, float radius, float x, float y, float z)
        {
            var go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            go.transform.position = new Vector3(x, y, z);
            go.name = newName;
            go.transform.localScale = new Vector3(radius, radius, radius);
            go.AddComponent<Rigidbody>();
            go.AddComponent<SphereCollider>();
            var mr = go.GetComponent<MeshRenderer>();
            mr.material = UnityBridge.instance.defaultMaterial;
        }
    }
}
