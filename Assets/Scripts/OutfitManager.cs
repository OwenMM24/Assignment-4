using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class OutfitManager : MonoBehaviour
{
    public GameObject model;
    public Transform overlayParent;
    public int maxLayers = 6;
    private List<GameObject> activeClothes = new List<GameObject>();

    public void AddClothing(GameObject clothingPrefab)
    {
        if (activeClothes.Count >= maxLayers)
        {
            Destroy(activeClothes[0]);
            activeClothes.RemoveAt(0);
        }

        GameObject newClothing = Instantiate(clothingPrefab, overlayParent);
        activeClothes.Add(newClothing);
    }

    public void RemoveClothing(GameObject clothingInstance)
    {
        if (clothingInstance != null)
        {
            Destroy(clothingInstance);
        }
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
