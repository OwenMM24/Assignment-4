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
    int currentClothesIndex = 0;
    [SerializeField] Transform obj;
    [SerializeField] GameObject multiParent;
    [SerializeField] TextMeshProUGUI text;

    public void AddSet()
    {
        GameObject set = Instantiate(obj.gameObject);
        set.SetActive(false);
        clothes[currentClothesIndex] = set;

        DeleteChildren();

        //clothes[currentClothesIndex].SetActive();
        clothes[currentClothesIndex].transform.SetParent(multiParent.transform);
        clothes[currentClothesIndex].transform.localPosition = new Vector3(0, 0, 0);
        //Debug.LogWarning(set.transform.position);
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
        text.text = $"[Slot: {currentClothesIndex}]";

        if (clothes[currentClothesIndex] != null)
            clothes[currentClothesIndex].SetActive(true);
    }

    public void GoRight()
    {
        if (clothes[currentClothesIndex] != null)
            clothes[currentClothesIndex].SetActive(false);

        currentClothesIndex = (currentClothesIndex + 1) % clothes.Length;
        text.text = $"[Slot: {currentClothesIndex}]";

        if (clothes[currentClothesIndex] != null)
            clothes[currentClothesIndex ].SetActive(true);
    }


    /*void AddSet(GameObject[] set)
    {
        if (currentClothesCount + set.Length <= clothes.Length)
        {
            for (int i = 0; i < set.Length; i++)
            {
                clothes[currentClothesCount] = set[i];
                currentClothesCount++;
            }
        }

    }*/


}
