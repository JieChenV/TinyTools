using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TinyTools.Extensions;

public class TexturePreviewExample : MonoBehaviour
{
    [TexturePreview(50)]
    public Texture2D TestTexture;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
