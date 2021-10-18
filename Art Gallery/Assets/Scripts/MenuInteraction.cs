using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject OptionsButton = GameObject.Find("Options");
        GameObject Menu = GameObject.Find("Menu");
        GameObject MusicToggle = GameObject.Find("MusicToggle");
        
        //hide menu items when menu is closed
        Menu.SetActive(false);
        MusicToggle.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
