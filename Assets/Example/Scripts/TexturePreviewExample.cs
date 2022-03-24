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

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}



