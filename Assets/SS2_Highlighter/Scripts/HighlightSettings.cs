using UnityEngine;

[CreateAssetMenu(fileName = "HighlightSettings", menuName = "Studio-23/SS2/HighlightSettings", order = 1)]
public class HighlightSettings : ScriptableObject
{
    public Material highlightMaterial;
    [ColorUsage(true, true)] 
    public Color highlightColor = Color.yellow;
    public int targetedLayer;
    
    private string colorPropertyName = "_Outline_Color";

    public void ApplyColor()
    {
        if (highlightMaterial != null)
        {
            if (highlightMaterial.HasProperty(colorPropertyName))
            {
                highlightMaterial.SetColor(colorPropertyName, highlightColor);
            }
            else
            {
                Debug.LogError($"Material does not have a color property named '{colorPropertyName}'");
            }
        }
    }
}