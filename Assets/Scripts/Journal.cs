using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
//using System.Diagnostics;

//using System.Diagnostics;

//using System.Diagnostics;
using UnityEngine;

public class Journal : MonoBehaviour
{
    public GameObject[] clothes = new GameObject[5];
    int currentClothesIndex = 0;
    [SerializeField] GameObject obj;
    [SerializeField] GameObject multiParent;

    public void AddSet()
    {
        GameObject set = Instantiate(obj);
        set.SetActive(false);
        clothes[currentClothesIndex] = set;

        //clothes[currentClothesIndex].SetActive();
        clothes[currentClothesIndex].transform.SetParent(multiParent.transform);
        clothes[currentClothesIndex].transform.localPosition = new Vector3(0, 0, 0);
        //Debug.LogWarning(set.transform.position);
        clothes[currentClothesIndex].transform.localRotation = Quaternion.Euler(0, 0, 0);
        currentClothesIndex = (currentClothesIndex + 1) % clothes.Length;
    }

    void AddToMulti()
    {
        
    }


    public void GoLeft()
    {
        Debug.LogWarning(currentClothesIndex - 1);
        if (clothes[currentClothesIndex - 1] != null)
        {
            clothes[currentClothesIndex].SetActive(false);
            clothes[currentClothesIndex - 1].SetActive(true);
            currentClothesIndex--;
        }
    }

    public void GoRight()
    {
        Debug.LogWarning(currentClothesIndex - 1);
        if (clothes[currentClothesIndex + 1] != null)
        {
            clothes[currentClothesIndex].SetActive(false);
            clothes[currentClothesIndex + 1].SetActive(true);
            currentClothesIndex++;
        }
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
