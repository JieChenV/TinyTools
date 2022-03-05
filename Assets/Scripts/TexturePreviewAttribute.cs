using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TexturePreviewAttribute : Attribute
{
    int previewSize = 40;

    public TexturePreviewAttribute(int size = 40) {
        this.previewSize = size;
    }
}
