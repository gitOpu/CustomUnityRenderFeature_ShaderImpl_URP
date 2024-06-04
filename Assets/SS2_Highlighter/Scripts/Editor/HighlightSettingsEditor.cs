using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(HighlightSettings))]
public class HighlightSettingsEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        HighlightSettings settings = (HighlightSettings)target;

        if (GUILayout.Button("Save"))
        {
            settings.ApplyColor();
            EditorUtility.SetDirty(settings.highlightMaterial);  // Mark the material as dirty so changes are saved
        }
    }
}