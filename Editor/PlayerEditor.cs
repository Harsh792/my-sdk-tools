using UnityEngine;
using UnityEditor;
using MyCompanyData;


[CustomEditor(typeof(Player))]
public class PlayerEditor:Editor
{
    SerializedProperty prop;

    private void OnEnable()
    {
        prop = serializedObject.FindProperty("playerHealth");
    }


    public override void OnInspectorGUI()
    {
        serializedObject.Update();
      
        

        DrawDefaultInspector();
      
        GUILayout.Space(10);

        EditorGUILayout.LabelField("Quick Actions", EditorStyles.boldLabel);

        if (GUILayout.Button("Max Health"))
        {
            prop.intValue = 100;
        }

        if (GUILayout.Button("Min Health"))
        {
            prop.intValue = 1;
        }

        serializedObject.ApplyModifiedProperties();
    }
}
