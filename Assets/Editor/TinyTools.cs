using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TinyTools : EditorWindow
{

    private bool mouseDown;
    private bool mouseUp;
    private bool isFreeAreaToggled;
    private bool isAreaScreenshot = true;
    

    [MenuItem("Tools/TinyTools")]
    public static void Init() {
        GetWindow<TinyTools>("Tiny Tools");
    }

    private void OnGUI()
    {
        GUILayout.Label("Screenshot", EditorStyles.boldLabel);
        FullScreenshot();
    }


    /// <summary>
    /// take a full-screen screenshot from the game window 
    /// </summary>
    private void FullScreenshot() {
        if (GUILayout.Button("Full Screenshot", GUILayout.MaxWidth(200), GUILayout.Height(30)))
        {
            System.IO.Directory.CreateDirectory("Screenshots");
            string imageName = System.DateTime.Now.ToString("Mddhhmmss") + ".png";
            ScreenCapture.CaptureScreenshot("Screenshots/" + imageName);
            Debug.Log("Full game scene screenshot " + imageName + " has been saved in Screenshots folder.");
        }
    }

    /// <summary>
    /// allow to take screenshot from selected rect area, not in use for now
    /// </summary>
    private void FreeAreaScreenshot() {

        isAreaScreenshot = GUILayout.Toggle(isFreeAreaToggled, "Area Screenshot", "Button") ;

        if (isAreaScreenshot != isFreeAreaToggled) {
            isFreeAreaToggled = isAreaScreenshot;
            if (isFreeAreaToggled) {

            }else
            {

            }
        }

       
    }
}
