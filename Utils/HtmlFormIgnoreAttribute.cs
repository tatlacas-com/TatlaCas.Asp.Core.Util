using System;

namespace TatlaCas.Asp.Utils.Utils
{
    /// <summary>Prevents a property from being shown on an html form as field.</summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class HtmlFormIgnoreAttribute : Attribute
    {
    }
}