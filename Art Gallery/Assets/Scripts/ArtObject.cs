using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtObject : MonoBehaviour
{
    [Header("Art Border")]
    [SerializeField] MeshRenderer artBorder;
    [SerializeField] Material normalBorderMat;
    [SerializeField] Material hightlightedBorderMat;

    [SerializeField] GameObject infoPanel;


    private void Awake()
    {
        infoPanel.SetActive(false);
        artBorder.material = normalBorderMat;
    }

    public void ShowInfoPanel()
    {
        infoPanel.SetActive(true);
    }

    public void HideInfoPanel()
    {
        infoPanel.SetActive(false);
    }


    #region Collider Trigger Events
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            artBorder.material = hightlightedBorderMat;
        //ShowInfoPanel();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
            artBorder.material = hightlightedBorderMat;
        //ShowInfoPanel();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            artBorder.material = normalBorderMat;
        //HideInfoPanel();
    }
    #endregion Collider Trigger Events
}
