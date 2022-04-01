using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinyTools.Extensions
{
    public static class DebugExtension 
    {
        public static void LogRed( this Debug debug, object message)
        {
           
            Debug.Log("<color=red>" + message + "</color>");
        }
    }
}
