using UnityEngine;
using UnityEditor;

public class MyEditorWindow : EditorWindow
{
    [MenuItem("Tools/My Editor Window")]
    public static void Open()
    {
        GetWindow<MyEditorWindow>("My Tools");
    }


    private void OnGUI()
    {
        GUILayout.Label("My Custom Tool", EditorStyles.boldLabel);
        
        if(GUILayout.Button("Click Me"))
        {
            Debug.Log("Button Clicked");
        }
    }
}
