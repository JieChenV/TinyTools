using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;
using System;
using System.Linq;
using TinyTools.Attributes;

namespace TinyTools.Editor
{
    public class TinyTools : EditorWindow
    {

        private bool mouseDown;
        private bool mouseUp;
        private bool isFreeAreaToggled;
        private bool isAreaScreenshot = true;

        private List<MemberInfo> _customizedMemberInfo = new List<MemberInfo>();

        [MenuItem("Tools/TinyTools")]
        public static void Init()
        {
            GetWindow<TinyTools>("Tiny Tools");
        }

        private void OnGUI()
        {
            GUILayout.Label("Screenshot", EditorStyles.boldLabel);
            FullScreenshot();
            GUILayout.Space(50);
            GUILayout.Label("Monitor Resolution: " + Screen.currentResolution);
            GUILayout.Label("Camera's Resolution: " + Camera.main.pixelRect.width + " x " + Camera.main.pixelRect.height);
        }

        private void OnEnable()
        {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();

            foreach (Assembly assembly in assemblies)
            {
                Type[] types = assembly.GetTypes();
                foreach (Type type in types)
                {
                    BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

                    MemberInfo[] members = type.GetMembers(flags);

                    foreach (MemberInfo member in members)
                    {
                        if (member.CustomAttributes.ToArray().Length > 0)
                        {
                            TexturePreviewAttribute texturePreviewAttribute = member.GetCustomAttribute<TexturePreviewAttribute>();
                            if (texturePreviewAttribute != null)
                            {
                                _customizedMemberInfo.Add(member);
                            }
                        }
                    }

                }
            }
        }


        /// <summary>
        /// take a full-screen screenshot from the game window 
        /// </summary>
        private void FullScreenshot()
        {
            GUILayout.BeginArea(new Rect((Screen.width / 2) - 50, 30, 100, 100));

            if (GUILayout.Button("Full Screenshot", GUILayout.MaxWidth(100), GUILayout.Height(30)))
            {
                System.IO.Directory.CreateDirectory("Screenshots");
                string imageName = System.DateTime.Now.ToString("Mddhhmmss") + ".png";
                ScreenCapture.CaptureScreenshot("Screenshots/" + imageName);
                Debug.Log("Full game scene screenshot " + imageName + " has been saved in Screenshots folder.");
            }

            GUILayout.EndArea();

        }

        /// <summary>
        /// allow to take screenshot from selected rect area, not in use for now
        /// </summary>
        private void FreeAreaScreenshot()
        {

            isAreaScreenshot = GUILayout.Toggle(isFreeAreaToggled, "Area Screenshot", "Button");

            if (isAreaScreenshot != isFreeAreaToggled)
            {
                isFreeAreaToggled = isAreaScreenshot;
                if (isFreeAreaToggled)
                {

                }
                else
                {

                }
            }


        }
    }
}

