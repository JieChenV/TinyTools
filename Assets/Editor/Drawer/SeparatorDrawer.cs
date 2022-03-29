using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using TinyTools.Attributes;

namespace TinyTools.Editor
{
    [CustomPropertyDrawer(typeof(SeparatorAttribute))]
    public class SeparatorDrawer : DecoratorDrawer
    {
        public override void OnGUI(Rect position)
        {
            SeparatorAttribute separatorAttribute = attribute as SeparatorAttribute;

            Rect separatorRect = new Rect(position.xMin,
                position.yMin + separatorAttribute.Space,
                position.width,
                separatorAttribute.Height);
            EditorGUI.DrawRect(separatorRect, Color.white);
        }

        public override float GetHeight()
        {
            SeparatorAttribute separatorAttribute = attribute as SeparatorAttribute;

            return separatorAttribute.Height + separatorAttribute.Space * 2;
        }
    }

}
