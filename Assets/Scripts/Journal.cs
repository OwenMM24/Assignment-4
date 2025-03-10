using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journal : MonoBehaviour
{
    public GameObject[] clothes = new GameObject[5];
    int currentClothesCount = 0;



    void AddSet(GameObject[] set)
    {
        if (currentClothesCount + set.Length <= clothes.Length)
        {
            for (int i = 0; i < set.Length; i++)
            {
                clothes[currentClothesCount] = set[i];
                currentClothesCount++;
            }
        }

    }


}
