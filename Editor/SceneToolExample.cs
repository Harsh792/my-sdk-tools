using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Transform))]
public class SceneToolExample : Editor
{
    private void OnSceneGUI()
    {
        Transform t = target as Transform;
        Handles.Label(t.position, "Object Here - " + t.position);
      
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Transform t = target as Transform;
        if (GUILayout.Button("Reset Transform"))
        {
            t.position = Vector3.zero;
            t.eulerAngles = Vector3.zero;
            t.localScale = new Vector3(1, 1, 1);
        }
    }


}
