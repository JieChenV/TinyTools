using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinyTools.Utils
{
    public static class TinyDebug
    {
        static Color black = new Color(0,0,0,1);

        public static void Log(object message, string colorCode = "#000000" ) {
            if (colorCode != null)
                Debug.Log($"<color={colorCode}>" + message + "</color>");
            else
                Debug.Log(message);
        }

        public static void Log(object message, Color32 color)
        {
            Debug.Log($"<color=#{ColorUtility.ToHtmlStringRGB(color)}>" + message + "</color>");
        }

        public static void LogBold(object message, string colorCode = "#000000")
        {
            if (colorCode != null)
                Debug.Log($"<color={colorCode}><b>" + message + "</b></color>");
            else
                Debug.Log("<b>" + message + "</b>");
        }

        public static void LogBold(object message, Color32 color) {
            Debug.Log($"<color=#{ColorUtility.ToHtmlStringRGB(color)}><b>" + message + "</b></color>");

        }

        public static void LogRed(object message) {
            Debug.Log("<color=red>" + message + "</color>");
        }

    }

}
