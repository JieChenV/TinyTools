using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinyTools.Extensions
{
    public static class ColorExtension 
    {
        public static string RgbToHex(this Color color)
        {
            int r = (int)color.r, g = (int)color.g, b = (int)color.b;
            return string.Format("#{0}{1}{2}", r.ToString("X2"), g.ToString("X2"), b.ToString("X2"));
        }
    }
}

