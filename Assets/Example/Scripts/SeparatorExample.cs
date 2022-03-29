using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TinyTools.Attributes;


namespace TinyTools.Examples
{
    public class SeparatorExample : MonoBehaviour
    {
        public int Health;

        [Separator(2, 20)]

        public int Armor;


    }
}

