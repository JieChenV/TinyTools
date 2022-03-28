using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using TinyTools.Attributes;

namespace TinyTools.Editor
{
    [CustomPropertyDrawer(typeof(TexturePreviewAttribute))]
    public class TexturePreviewDrawer : PropertyDrawerBase
    {

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return GetAssetPreviewSize(property).x + EditorGUIUtility.singleLineHeight;
        }

        public override void OnGUI(Rect rect, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(rect, label, property);

            // check the property
            if (property.propertyType == SerializedPropertyType.ObjectReference)
            {
                // 1. draw the default label
                Rect propertyRect = new Rect()
                {
                    x = rect.x,
                    y = rect.y,
                    width = rect.width,
                    height = EditorGUIUtility.singleLineHeight
                };

                EditorGUI.PropertyField(propertyRect, property, label);


                // 2. draw the preview
                Texture2D previewTexture = GetAssetPreview(property);
                if (previewTexture != null)
                {
                    Rect previewRect = new Rect()
                    {
                        x = rect.x + EditorGUIUtility.singleLineHeight,
                        y = rect.y + EditorGUIUtility.singleLineHeight,
                        width = GetAssetPreviewSize(property).x,
                        height = GetAssetPreviewSize(property).y
                    };

                    GUI.Label(previewRect, previewTexture);
                }
            }
            else
            {
                string message = property.name + " doesn't have an asset preview";
                EditorGUI.HelpBox(rect, message, MessageType.Info);
            }

            EditorGUI.EndProperty();
        }

        private Texture2D GetAssetPreview(SerializedProperty property)
        {
            if (property.propertyType == SerializedPropertyType.ObjectReference)
            {
                if (property.objectReferenceValue != null)
                {
                    Texture2D previewTexture = (Texture2D)property.objectReferenceValue; //  AssetPreview.GetAssetPreview(property.objectReferenceValue);
                    return previewTexture;
                }

                return null;
            }

            return null;
        }

        private Vector2 GetAssetPreviewSize(SerializedProperty property)
        {
            Texture2D previewTexture = GetAssetPreview(property);
            if (previewTexture == null)
            {
                return Vector2.zero;
            }
            else
            {
                int targetWidth = TexturePreviewAttribute.DefaultWidth;
                int targetHeight = TexturePreviewAttribute.DefaultWidth ;

                TexturePreviewAttribute texturePreviewAttribute = (TexturePreviewAttribute) attribute;
                if (texturePreviewAttribute != null)
                {
                    targetWidth = texturePreviewAttribute.PreviewWidth;
                    targetHeight = texturePreviewAttribute.PreviewHeight;
                }

                int width = Mathf.Clamp(targetWidth, 0, previewTexture.width);
                int height = Mathf.Clamp(targetHeight, 0, previewTexture.height);

                return new Vector2(width, height);
            }
        }
    }
}

