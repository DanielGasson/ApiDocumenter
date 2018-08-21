using System;
using Microsoft.AspNetCore.Mvc;

namespace ApiDocGenerator.Extensions
{
    public static class TypeExtensions
    {
        /// <summary>
        /// Returns true if a type is of type API controller
        /// </summary>
        public static bool IsApiController(this Type type)
        {
            return type.IsAssignableFrom(typeof(Controller)) || type.IsSubclassOf(typeof(Controller));
        }
    }
}
