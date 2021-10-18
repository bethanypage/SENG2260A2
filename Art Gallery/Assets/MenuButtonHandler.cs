using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonHandler : MonoBehaviour
{
    public void toggleMenu(){
        GameObject Menu = GameObject.Find("Menu");
        GameObject MusicToggle = GameObject.Find("MusicToggle");
        
        //Toggle the menu items depending on their state
        bool isActive = Menu.activeSelf;
        Debug.Log(isActive);

        Menu.SetActive(!isActive);
        MusicToggle.SetActive(!isActive);
    }

}
