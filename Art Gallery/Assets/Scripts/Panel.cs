using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    //public string panelName;
    public bool isActive;

    public void SetActive(bool setActive)
    {
        isActive = setActive;
        gameObject.SetActive(isActive);
    }


    public void TogglePanel()
    {
        isActive = !isActive;

        gameObject.SetActive(isActive);
    }
}
