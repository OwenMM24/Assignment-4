using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class EquipItem : MonoBehaviour
{

    [SerializeField] GameObject[] outfits;
    [SerializeField] GameObject[] trackers;




    public void SetObject(int i)
    {
        foreach (var item in outfits)
        {
            if (item == outfits[i])
                item.SetActive(true);
            else
                item.SetActive(false);
        }
    }

    public void DisableObject(int i)
    {
        outfits[i].SetActive(false);
    }
}
