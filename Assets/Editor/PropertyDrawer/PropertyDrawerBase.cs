using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class PropertyDrawerBase : PropertyDrawer
{
    public sealed override void OnGUI(Rect rect, SerializedProperty property, GUIContent label)
    {
        // Check if visible
    }
}
