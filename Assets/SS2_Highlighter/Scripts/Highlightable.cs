using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlightable : HighlightableObject
{
    private int originalLayer;

    protected override void Awake()
    {
        base.Awake();
        originalLayer = gameObject.layer;
    }

    public override void Select()
    {
        if (highlightSettings != null)
        {
            SetLayer(gameObject, highlightSettings.targetedLayer);
        }
        else
        {
            Debug.LogError("Highlight settings not found!");
        }
    }

    public override void Deselect()
    {
        SetLayer(gameObject, originalLayer);
    }
}