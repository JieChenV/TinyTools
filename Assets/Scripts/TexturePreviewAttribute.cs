using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TexturePreviewAttribute : Attribute
{
    int previewWidth = 40;
    int previewHeight = 40;

    public TexturePreviewAttribute(int width, int height  ) {
        this.previewWidth = width;
        this.previewHeight = height;
    }

    public TexturePreviewAttribute() { }
}
