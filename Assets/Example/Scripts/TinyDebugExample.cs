using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TinyTools.Utils;
using TinyTools.Extensions;

public class TinyDebugExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // TinyDebug example
        TinyDebug.LogRed("LogRed Test");
        TinyDebug.Log("Log with Hex color test", "#265415");
        TinyDebug.Log("Log with Built-in color test", Color.green);
        TinyDebug.LogBold("LogBold with Hex color test", "#265415");
        TinyDebug.LogBold("LogBold with Built-in color test", Color.green);


        // String extension for Debug.Log() example

        Debug.Log("This is " +  "Blod Text".Bold());
        Debug.Log("This is " + "Italic Text".Italic());
        Debug.Log("This is " + "Colorful Text".Color("#FF2520"));
        Debug.Log("This is " + "Built-in Colorful Text".Color(Color.blue));
        Debug.Log(" \u2764");
        Debug.Log(" \u21E7".Bold());
        Debug.Log(" \u20DD".Bold());
        Debug.Log(" \u20DE".Bold());
        Debug.Log(" \u20DF".Bold().Color(Color.cyan));




    }

}
