using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class OutfitManager : MonoBehaviour
{
    public GameObject model;  // Base model to overlay clothes on
    public Transform overlayParent; // Parent object where clothes are added
    public int maxLayers = 6;       // Limit max clothing overlays
    private List<GameObject> activeClothes = new List<GameObject>();

    public void AddClothing(GameObject clothingPrefab)
    {
        if (activeClothes.Count >= maxLayers)
        {
            // Remove oldest clothing item if limit is exceeded
            Destroy(activeClothes[0]);
            activeClothes.RemoveAt(0);
        }

        // Instantiate new clothing item and attach it to the person
        GameObject newClothing = Instantiate(clothingPrefab, overlayParent);
        activeClothes.Add(newClothing);
    }

    public void ClearOutfit()
    {
        foreach (GameObject clothing in activeClothes)
        {
            Destroy(clothing);
        }
        activeClothes.Clear();
    }
}
