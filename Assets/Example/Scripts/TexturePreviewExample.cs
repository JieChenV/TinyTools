using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TinyTools.Extensions;
using TinyTools.Editor;

namespace TinyTools.Examples {
    public class TexturePreviewExample : MonoBehaviour
    {
        [TexturePreview(128, 128)]
        public Texture2D CustomizedPreviewTex;

        [TexturePreview]
        public Texture2D DefaultPreviewTex;

        [SerializeField]
        public int TestInt;

        [SerializeField]
        public Color TestColor;
        // Start is called before the first frame update
        void Start()
        {
            Color color = new Color(69, 12, 65);
            //int r = (int)color.r, g = (int)color.g, b = (int)color.b;
            //string _color = r.ToString("X2") + g.ToString("X2") + b.ToString("X2");
            Debug.Log("The Color is :" + color.RgbToHex());

        }

        // Update is called once per frame
        void Update()
        {
            //Debug.Log("The Hex for the color is: " + TestColor.RgbToHex());
        }
    }
}



