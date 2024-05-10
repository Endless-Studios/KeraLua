using System;

namespace KeraLua
{
    /// <summary>
    /// Fake attribute to help compilation
    /// </summary>
    [AttributeUsage(AttributeTargets.Delegate)]
    public class MonoNativeFunctionWrapperAttribute : Attribute
    {
        
    }
}
