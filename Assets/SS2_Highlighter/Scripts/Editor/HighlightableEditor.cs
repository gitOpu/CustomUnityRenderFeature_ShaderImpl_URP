using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Highlightable))]
public class HighlightableEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Highlightable highlightable = (Highlightable)target;

        if (GUILayout.Button("Select"))
        {
            highlightable.Select();
        }

        if (GUILayout.Button("Deselect"))
        {
            highlightable.Deselect();
        }

        if (GUILayout.Button("Select All"))
        {
            HighlightableObject.SelectAll();
        }

        if (GUILayout.Button("Deselect All"))
        {
            HighlightableObject.DeselectAll();
        }
    }
}