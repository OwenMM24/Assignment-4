using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using System.Security.Cryptography;

//using System.Security.Policy;
using UnityEngine;

public class Tracker : MonoBehaviour
{
    public bool objectTrack;
    [SerializeField] GameObject outfitParent;
    [SerializeField] int arrayIndex;

    public void OnObjectFound()
    {
        outfitParent.GetComponent<EquipItem>().SetObject(arrayIndex);
        objectTrack = true;
    }

    public void OnObjectLost()
    {
        outfitParent.GetComponent<EquipItem>().DisableObject(arrayIndex);
        objectTrack = false;
    }

}
