using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinyTools.Extensions
{
    public static class StringExtension
    {
        /// <summary>
        /// used for Debug.Log with bold text
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Bold(this string s) =>  "<b>" + s + "</b>";

        /// <summary>
        /// used for Debug.Log with italic text
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Italic(this string s) => "<i>" + s + "</i>";


        /// <summary>
        /// used for Debug.Log with dynamic size text
        /// </summary>
        /// <param name="s"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static string Size(this string s, int size) => $"<size={size}>{s}</size>";

        /// <summary>
        /// used for Debug.Log with Color
        /// </summary>
        /// <param name="s"></param>
        /// <param name="colorCode"></param>
        /// <returns></returns>
        public static string Color(this string s, string colorCode) => $"<color={colorCode}>{s}</color>";

        /// <summary>
        /// used for Debug.Log with built-in color
        /// </summary>
        /// <param name="s"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string Color(this string s, Color color) => $"<color=#{ColorUtility.ToHtmlStringRGB(color)}>{s}</color>";


    }
}

