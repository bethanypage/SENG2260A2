using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtObject : MonoBehaviour
{
    [Header("Art Border")]
    [SerializeField] MeshRenderer artBorder;
    [SerializeField] Material normalBorderMat;
    [SerializeField] Material hightlightedBorderMat;

    [Header("UI")]
    [SerializeField] GameObject infoButton;
    [SerializeField] GameObject infoPanel;
    bool showPanel;

    private void Awake()
    {
        infoButton.SetActive(false);
        infoPanel.SetActive(false);
        showPanel = infoPanel.activeSelf;
        artBorder.material = normalBorderMat;
    }

    #region InfoButton
    void ShowInfoButton()
    {
        infoButton.SetActive(true);
    }

    void HideInfoButton()
    {
        infoButton.SetActive(false);
    }
    #endregion InfoButton

    #region InfoPanel
    public void ToggleInfoPanel()
    {
        showPanel = !showPanel;

        if (showPanel) { ShowInfoPanel(); }
        else { HideInfoPanel(); }
    }

    public void ShowInfoPanel()
    {
        infoPanel.SetActive(true);
    }

    public void HideInfoPanel()
    {
        infoPanel.SetActive(false);
    }
    #endregion InfoPanel


    #region Collider Trigger Events
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            artBorder.material = hightlightedBorderMat;
            ShowInfoButton();
        }
    }

    /*
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
            artBorder.material = hightlightedBorderMat;
        //ShowInfoPanel();
    }
    */

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            artBorder.material = normalBorderMat;
            HideInfoButton();
            HideInfoPanel();
        }
    }
    #endregion Collider Trigger Events
}
