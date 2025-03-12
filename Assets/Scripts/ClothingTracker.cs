using UnityEngine;
using Vuforia;

public class ClothingTracker : MonoBehaviour // Assigns clothing targets to respective clothing prefabs
{
    public GameObject[] clothingPrefabs;
    private OutfitManager outfitManager;
    private int currentIndex = 0;

    void Start()
    {
        outfitManager = FindObjectOfType<OutfitManager>();
    }

    public void OnTargetFound() // uses outfit manager to "wear" associated prefab
    {
        if (outfitManager != null && clothingPrefabs.Length > 0)
        {
            outfitManager.AddClothing(clothingPrefabs[currentIndex]);
        }
    }

    public void SwitchToAlternate()
    {
        Debug.Log("Button pressed!");
        if (clothingPrefabs.Length > 1)
        {
            currentIndex = (currentIndex + 1) % clothingPrefabs.Length;

            if (outfitManager != null)
            {
                outfitManager.AddClothing(clothingPrefabs[currentIndex]);
            }
        }
    }
}
