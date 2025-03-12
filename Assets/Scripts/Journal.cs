using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
//using System.Diagnostics;

//using System.Diagnostics;

//using System.Diagnostics;
using UnityEngine;
using TMPro;

public class Journal : MonoBehaviour
{
    public GameObject[] clothes = new GameObject[5];
    public int[] clothesUses = new int[5];
    int currentClothesIndex = 0;
    [SerializeField] Transform obj;
    [SerializeField] GameObject multiParent;
    [SerializeField] TextMeshProUGUI slotText;
    [SerializeField] TextMeshProUGUI usesText;

    public void AddSet()
    {
        GameObject set = Instantiate(obj.gameObject);
        set.SetActive(false);
        if (clothes[currentClothesIndex] != null )
        {
            Destroy(clothes[currentClothesIndex]);
        }
        clothes[currentClothesIndex] = set;

        DeleteChildren();

        
        clothes[currentClothesIndex].transform.SetParent(multiParent.transform);
        clothes[currentClothesIndex].transform.localPosition = new Vector3(0, 0, 0);
        
        clothes[currentClothesIndex].transform.localRotation = Quaternion.Euler(0, 0, 0);
        currentClothesIndex = (currentClothesIndex + 1) % clothes.Length;

        
    }

    void DeleteChildren()
    {
        foreach (Transform child in obj)
        {
            if (child != null)
            {
                Destroy(child.gameObject);
            }
        }
    }


    public void GoLeft()
    {
        if (clothes[currentClothesIndex] != null)
            clothes[currentClothesIndex].SetActive(false);

        currentClothesIndex = (currentClothesIndex - 1 + clothes.Length) % clothes.Length;
        slotText.text = $"[Slot {currentClothesIndex + 1}]";
        usesText.text = $"Outfit Worn {clothesUses[currentClothesIndex]} Times";

        if (clothes[currentClothesIndex] != null)
            clothes[currentClothesIndex].SetActive(true);
    }

    public void GoRight()
    {
        if (clothes[currentClothesIndex] != null)
            clothes[currentClothesIndex].SetActive(false);

        currentClothesIndex = (currentClothesIndex + 1) % clothes.Length;
        slotText.text = $"[Slot {currentClothesIndex + 1}]";
        usesText.text = $"Outfit Worn {clothesUses[currentClothesIndex]} Times";

        if (clothes[currentClothesIndex] != null)
            clothes[currentClothesIndex ].SetActive(true);
    }

    public void IncreaseOutfitUses()
    {
        clothesUses[currentClothesIndex]++;
        usesText.text = $"Outfit Worn {clothesUses[currentClothesIndex]} Times";
        //outfitUses++;

    }

}
