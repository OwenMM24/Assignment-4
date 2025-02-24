using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject panel;
    bool panelEnabled = false;

    public void OpenMenu()
    {
        if (panelEnabled)
        {
            panel.SetActive(false);
            panelEnabled = false;
        }
        else
        {
            panel.SetActive(true);
            panelEnabled = true;
        }
    }


}
