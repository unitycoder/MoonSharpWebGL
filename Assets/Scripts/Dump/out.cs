//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.9174
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// ----------------------------------------------------------
// Generated by MoonSharp.Hardwire v.1.0.8838.26494
// Compatible with MoonSharp v.2.0.0.0 or equivalent
// ----------------------------------------------------------
// Code generated on 2024-03-13T14:44:46.2595348+02:00
// ----------------------------------------------------------
// 
// 
// 
using Lua;

namespace MyNamespace
{
    public abstract class MyClass
    {
        private MyClass()
        {
        }

        public static void Initialize()
        {
            MoonSharp.Interpreter.UserData.RegisterType(new TYPE_e86a70e0a7fd4ef5895cb9735d5ef4e4());
        }

        #region Descriptor of LuaAPI
        // Descriptor of LuaAPI
        private sealed class TYPE_e86a70e0a7fd4ef5895cb9735d5ef4e4 : MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors.HardwiredUserDataDescriptor
        {

            internal TYPE_e86a70e0a7fd4ef5895cb9735d5ef4e4() :
                    base(typeof(LuaAPI))
            {
                this.AddMember("__new", new MoonSharp.Interpreter.Interop.OverloadedMethodMemberDescriptor("__new", typeof(LuaAPI), new MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor[] {
                                new MTHD_4d97b74730494e9ea173a9a4d21d0ba9()}));
                this.AddMember("CreateSphere", new MoonSharp.Interpreter.Interop.OverloadedMethodMemberDescriptor("CreateSphere", typeof(LuaAPI), new MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor[] {
                                new MTHD_cfc3509ce708473092d66c59a4263897()}));
                this.AddMember("SetDirty", new MoonSharp.Interpreter.Interop.OverloadedMethodMemberDescriptor("SetDirty", typeof(LuaAPI), new MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor[] {
                                new MTHD_998c902681ec4788af47db86d666c727()}));
                this.AddMember("GetInstanceID", new MoonSharp.Interpreter.Interop.OverloadedMethodMemberDescriptor("GetInstanceID", typeof(LuaAPI), new MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor[] {
                                new MTHD_6c7650333327472d90888082ee982c5e()}));
                this.AddMember("GetHashCode", new MoonSharp.Interpreter.Interop.OverloadedMethodMemberDescriptor("GetHashCode", typeof(LuaAPI), new MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor[] {
                                new MTHD_16968dd1307a4d5eaa6a64eb872a5b03()}));
                this.AddMember("Equals", new MoonSharp.Interpreter.Interop.OverloadedMethodMemberDescriptor("Equals", typeof(LuaAPI), new MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor[] {
                                new MTHD_e411178b9ab6427f989b54259afb351d()}));
                this.AddMember("get_name", new MoonSharp.Interpreter.Interop.OverloadedMethodMemberDescriptor("get_name", typeof(LuaAPI), new MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor[] {
                                new MTHD_cfb44b686bb9493288f2fcbf359ffa69()}));
                this.AddMember("set_name", new MoonSharp.Interpreter.Interop.OverloadedMethodMemberDescriptor("set_name", typeof(LuaAPI), new MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor[] {
                                new MTHD_d3a0eba18fb345f6aa7fa8929daa12b9()}));
                this.AddMember("get_hideFlags", new MoonSharp.Interpreter.Interop.OverloadedMethodMemberDescriptor("get_hideFlags", typeof(LuaAPI), new MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor[] {
                                new MTHD_508ef48dea704c5ca0f594bdefa3469f()}));
                this.AddMember("set_hideFlags", new MoonSharp.Interpreter.Interop.OverloadedMethodMemberDescriptor("set_hideFlags", typeof(LuaAPI), new MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor[] {
                                new MTHD_a5c11c02ce524d8eb1f2d4b05c5cf7fd()}));
                this.AddMember("ToString", new MoonSharp.Interpreter.Interop.OverloadedMethodMemberDescriptor("ToString", typeof(LuaAPI), new MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor[] {
                                new MTHD_5573596835dd41c49741c4b9e2230434()}));
                this.AddMember("GetType", new MoonSharp.Interpreter.Interop.OverloadedMethodMemberDescriptor("GetType", typeof(LuaAPI), new MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor[] {
                                new MTHD_2fef22e8276c406ba64f315b926abc19()}));
                this.AddMember("name", new PROP_bea7af54bb9840298603fd05d60edfa8());
                this.AddMember("hideFlags", new PROP_91c228b2d1674a57bb0950dba1807363());
            }

            private sealed class MTHD_4d97b74730494e9ea173a9a4d21d0ba9 : MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors.HardwiredMethodMemberDescriptor
            {

                internal MTHD_4d97b74730494e9ea173a9a4d21d0ba9()
                {
                    this.Initialize(".ctor", true, new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor[0], false);
                }

                protected override object Invoke(MoonSharp.Interpreter.Script script, object obj, object[] pars, int argscount)
                {
                    return new LuaAPI();
                }
            }

            private sealed class MTHD_cfc3509ce708473092d66c59a4263897 : MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors.HardwiredMethodMemberDescriptor
            {

                internal MTHD_cfc3509ce708473092d66c59a4263897()
                {
                    this.Initialize("CreateSphere", false, new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor[] {
                                new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor("newName", typeof(string), false, null, false, false, false),
                                new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor("radius", typeof(float), false, null, false, false, false),
                                new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor("x", typeof(float), false, null, false, false, false),
                                new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor("y", typeof(float), false, null, false, false, false),
                                new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor("z", typeof(float), false, null, false, false, false)}, false);
                }

                protected override object Invoke(MoonSharp.Interpreter.Script script, object obj, object[] pars, int argscount)
                {
                    ((LuaAPI)(obj)).CreateSphere(((string)(pars[0])), ((float)(pars[1])), ((float)(pars[2])), ((float)(pars[3])), ((float)(pars[4])));
                    return MoonSharp.Interpreter.DynValue.Void;
                }
            }

            private sealed class MTHD_998c902681ec4788af47db86d666c727 : MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors.HardwiredMethodMemberDescriptor
            {

                internal MTHD_998c902681ec4788af47db86d666c727()
                {
                    this.Initialize("SetDirty", false, new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor[0], false);
                }

                protected override object Invoke(MoonSharp.Interpreter.Script script, object obj, object[] pars, int argscount)
                {
                    ((UnityEngine.ScriptableObject)(obj)).SetDirty();
                    return MoonSharp.Interpreter.DynValue.Void;
                }
            }

            private sealed class MTHD_6c7650333327472d90888082ee982c5e : MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors.HardwiredMethodMemberDescriptor
            {

                internal MTHD_6c7650333327472d90888082ee982c5e()
                {
                    this.Initialize("GetInstanceID", false, new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor[0], false);
                }

                protected override object Invoke(MoonSharp.Interpreter.Script script, object obj, object[] pars, int argscount)
                {
                    return ((UnityEngine.Object)(obj)).GetInstanceID();
                }
            }

            private sealed class MTHD_16968dd1307a4d5eaa6a64eb872a5b03 : MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors.HardwiredMethodMemberDescriptor
            {

                internal MTHD_16968dd1307a4d5eaa6a64eb872a5b03()
                {
                    this.Initialize("GetHashCode", false, new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor[0], false);
                }

                protected override object Invoke(MoonSharp.Interpreter.Script script, object obj, object[] pars, int argscount)
                {
                    return ((UnityEngine.Object)(obj)).GetHashCode();
                }
            }

            private sealed class MTHD_e411178b9ab6427f989b54259afb351d : MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors.HardwiredMethodMemberDescriptor
            {

                internal MTHD_e411178b9ab6427f989b54259afb351d()
                {
                    this.Initialize("Equals", false, new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor[] {
                                new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor("other", typeof(object), false, null, false, false, false)}, false);
                }

                protected override object Invoke(MoonSharp.Interpreter.Script script, object obj, object[] pars, int argscount)
                {
                    return ((UnityEngine.Object)(obj)).Equals(((object)(pars[0])));
                }
            }

            private sealed class MTHD_cfb44b686bb9493288f2fcbf359ffa69 : MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors.HardwiredMethodMemberDescriptor
            {

                internal MTHD_cfb44b686bb9493288f2fcbf359ffa69()
                {
                    this.Initialize("get_name", false, new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor[0], false);
                }

                protected override object Invoke(MoonSharp.Interpreter.Script script, object obj, object[] pars, int argscount)
                {
                    return ((UnityEngine.Object)(obj)).name;
                }
            }

            private sealed class MTHD_d3a0eba18fb345f6aa7fa8929daa12b9 : MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors.HardwiredMethodMemberDescriptor
            {

                internal MTHD_d3a0eba18fb345f6aa7fa8929daa12b9()
                {
                    this.Initialize("set_name", false, new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor[] {
                                new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor("value", typeof(string), false, null, false, false, false)}, false);
                }

                protected override object Invoke(MoonSharp.Interpreter.Script script, object obj, object[] pars, int argscount)
                {
                    UnityEngine.Object tmp = ((UnityEngine.Object)(obj));
                    tmp.name = ((string)(pars[0]));
                    return null;
                }
            }

            private sealed class MTHD_508ef48dea704c5ca0f594bdefa3469f : MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors.HardwiredMethodMemberDescriptor
            {

                internal MTHD_508ef48dea704c5ca0f594bdefa3469f()
                {
                    this.Initialize("get_hideFlags", false, new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor[0], false);
                }

                protected override object Invoke(MoonSharp.Interpreter.Script script, object obj, object[] pars, int argscount)
                {
                    return ((UnityEngine.Object)(obj)).hideFlags;
                }
            }

            private sealed class MTHD_a5c11c02ce524d8eb1f2d4b05c5cf7fd : MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors.HardwiredMethodMemberDescriptor
            {

                internal MTHD_a5c11c02ce524d8eb1f2d4b05c5cf7fd()
                {
                    this.Initialize("set_hideFlags", false, new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor[] {
                                new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor("value", typeof(UnityEngine.HideFlags), false, null, false, false, false)}, false);
                }

                protected override object Invoke(MoonSharp.Interpreter.Script script, object obj, object[] pars, int argscount)
                {
                    UnityEngine.Object tmp = ((UnityEngine.Object)(obj));
                    tmp.hideFlags = ((UnityEngine.HideFlags)(pars[0]));
                    return null;
                }
            }

            private sealed class MTHD_5573596835dd41c49741c4b9e2230434 : MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors.HardwiredMethodMemberDescriptor
            {

                internal MTHD_5573596835dd41c49741c4b9e2230434()
                {
                    this.Initialize("ToString", false, new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor[0], false);
                }

                protected override object Invoke(MoonSharp.Interpreter.Script script, object obj, object[] pars, int argscount)
                {
                    return ((UnityEngine.Object)(obj)).ToString();
                }
            }

            private sealed class MTHD_2fef22e8276c406ba64f315b926abc19 : MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors.HardwiredMethodMemberDescriptor
            {

                internal MTHD_2fef22e8276c406ba64f315b926abc19()
                {
                    this.Initialize("GetType", false, new MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor[0], false);
                }

                protected override object Invoke(MoonSharp.Interpreter.Script script, object obj, object[] pars, int argscount)
                {
                    return ((object)(obj)).GetType();
                }
            }

            private sealed class PROP_bea7af54bb9840298603fd05d60edfa8 : MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors.HardwiredMemberDescriptor
            {

                internal PROP_bea7af54bb9840298603fd05d60edfa8() :
                        base(typeof(string), "name", false, ((MoonSharp.Interpreter.Interop.BasicDescriptors.MemberDescriptorAccess)(3)))
                {
                }

                protected override object GetValueImpl(MoonSharp.Interpreter.Script script, object obj)
                {
                    return ((UnityEngine.Object)(obj)).name;
                }

                protected override void SetValueImpl(MoonSharp.Interpreter.Script script, object obj, object value)
                {
                    UnityEngine.Object tmp = ((UnityEngine.Object)(obj));
                    tmp.name = ((string)(value));
                }
            }

            private sealed class PROP_91c228b2d1674a57bb0950dba1807363 : MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors.HardwiredMemberDescriptor
            {

                internal PROP_91c228b2d1674a57bb0950dba1807363() :
                        base(typeof(UnityEngine.HideFlags), "hideFlags", false, ((MoonSharp.Interpreter.Interop.BasicDescriptors.MemberDescriptorAccess)(3)))
                {
                }

                protected override object GetValueImpl(MoonSharp.Interpreter.Script script, object obj)
                {
                    return ((UnityEngine.Object)(obj)).hideFlags;
                }

                protected override void SetValueImpl(MoonSharp.Interpreter.Script script, object obj, object value)
                {
                    UnityEngine.Object tmp = ((UnityEngine.Object)(obj));
                    tmp.hideFlags = ((UnityEngine.HideFlags)(value));
                }
            }
        }
        #endregion
    }
}