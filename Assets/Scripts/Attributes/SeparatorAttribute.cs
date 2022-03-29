using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

namespace TinyTools.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class SeparatorAttribute : PropertyAttribute
    {
        public readonly int Height;
        public readonly int Space;

        public SeparatorAttribute(int height = 2, int space = 10)
        {
            this.Height = height;
            this.Space = space;
        }
    }
}

