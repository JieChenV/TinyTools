using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinyTools.Editor
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class TexturePreviewAttribute : PropertyAttribute
    {
        public const int DefaultWidth = 40;
        public const int DefaultHeight = 40;
        public int PreviewWidth { get; set; }
        public int PreviewHeight { get; set; }

        public TexturePreviewAttribute(int width, int height)
        {
            this.PreviewWidth = width;
            this.PreviewHeight = height;
        }

        public TexturePreviewAttribute() {
            this.PreviewWidth = DefaultWidth;
            this.PreviewHeight = DefaultHeight;
        }
    }

}

