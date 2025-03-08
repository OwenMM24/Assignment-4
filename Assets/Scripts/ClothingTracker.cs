using UnityEngine;
using Vuforia;

public class ClothingTracker : MonoBehaviour
{
    public GameObject[] clothingPrefabs;
    private OutfitManager outfitManager;
    private int currentIndex = 0;

    void Start()
    {
        outfitManager = FindObjectOfType<OutfitManager>();
    }

    public void OnTargetFound()
    {
        if (outfitManager != null && clothingPrefabs.Length > 0)
        {
            outfitManager.AddClothing(clothingPrefabs[currentIndex]);
        }
    }

    void OnMouseDown()
    {
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
