using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HighlightableObject : MonoBehaviour
{
    protected HighlightSettings highlightSettings;

    protected virtual void Awake()
    {
        highlightSettings = Resources.Load<HighlightSettings>("HighlightSettings");
        if (highlightSettings == null)
        {
            Debug.LogError("HighlightSettings asset not found in Resources folder");
        }
    }

    public abstract void Select();
    public abstract void Deselect();

    public static void SelectAll()
    {
        HighlightableObject[] highlightableObjects = FindObjectsOfType<HighlightableObject>();

        foreach (HighlightableObject obj in highlightableObjects)
        {
            obj.Select();
        }
    }

    public static void DeselectAll()
    {
        HighlightableObject[] highlightableObjects = FindObjectsOfType<HighlightableObject>();

        foreach (HighlightableObject obj in highlightableObjects)
        {
            obj.Deselect();
        }
    }

    protected void SetLayer(GameObject obj, int newLayer)
    {
        if (obj == null) return;
        obj.layer = newLayer;

        foreach (Transform child in obj.transform)
        {
            if (child == null) continue;
            SetLayer(child.gameObject, newLayer);
        }
    }
}