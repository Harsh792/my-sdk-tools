using UnityEngine;
using UnityEditor;

public class MyFirstEditorTool
{
    [MenuItem("Tools/MyFirstTool")]
    public static void RunTool()
    {
        Debug.Log("Editor Tool Clicked");
    }
}
