using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TinyTools.Attributes;
using TinyTools.Utils;

namespace TinyTools.Examples
{
    public class SeparatorExample : MonoBehaviour
    {
        public int Health;

        [Separator(2, 20)]

        public int Armor;

        private void Start()
        {
            TinyDebug.LogRed("LogRed Test");
            TinyDebug.Log("Log with Hex color test", "#265415");
            TinyDebug.Log("Log with Built-in color test", Color.green);
            TinyDebug.LogBold("LogBold with Hex color test", "#265415");
            TinyDebug.LogBold("LogBold with Built-in color test", Color.green);
        }
    }
}

