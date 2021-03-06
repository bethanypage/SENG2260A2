using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtObject : MonoBehaviour
{
    [Header("Art Border")]
    [SerializeField] MeshRenderer[] artBorders;
    [SerializeField] Material normalBorderMat;
    [SerializeField] Material hightlightedBorderMat;

    [Header("UI")]
    [SerializeField] GameObject infoPanel;
    [SerializeField] GameObject buttonPanel;
    bool showPanel;

    [Header("Related Artworks")]
    [SerializeField] GameObject[] relatedArtObjects;
    [SerializeField] GameObject relatedArtLink;
    bool showRelated;
    [Range(0.01f, 1f)]
    [SerializeField] float linkStartWidth = 1f, linkEndWidth = 1f;
    List<GameObject> artLinks = new List<GameObject>();

    private void Awake()
    {
        HideButtonPanel();
        HideInfoPanel();       

        showPanel = infoPanel.activeSelf;

        for (int i = 0; i < artBorders.Length; i++)
        {
            artBorders[i].material = normalBorderMat;
        }
    }


    #region ButtonPanel
    void ShowButtonPanel()
    {
        buttonPanel.SetActive(true);
    }

    void HideButtonPanel()
    {
        buttonPanel.SetActive(false);
    }
    #endregion ButtonPanel

    #region InfoPanel
    public void ToggleInfoPanel()
    {
        showPanel = !showPanel;

        if (showPanel) { ShowInfoPanel(); }
        else { HideInfoPanel(); }
    }

    public void ShowInfoPanel()
    {
        showPanel = true;
        infoPanel.SetActive(true);
    }

    public void HideInfoPanel()
    {
        showPanel = false;
        infoPanel.SetActive(false);
    }
    #endregion InfoPanel

    #region RelatedArt
    public void ToggleRelatedArt()
    {
        showRelated = !showRelated;

        if (showRelated)
        {
            ShowRelatedArtwork();
        }
        else
        {
            HideRelatedArtwork();
        }
    }

    void ShowRelatedArtwork()
    {
        showRelated = true;

        if(relatedArtObjects.Length <= 0) { Debug.LogError($"{this.name} is missing related artworks");  return; }

        for (int i= 0; i < relatedArtObjects.Length; i++)
        {
            GameObject link = Instantiate(relatedArtLink, transform);
            LineRenderer linkRenderer = link.GetComponent<LineRenderer>();

            linkRenderer.SetPosition(0, transform.position);
            linkRenderer.SetPosition(1, relatedArtObjects[i].transform.position);
            linkRenderer.startWidth = linkStartWidth;
            linkRenderer.endWidth = linkEndWidth;
            artLinks.Add(link);
        }
    }

    void HideRelatedArtwork()
    {
        showRelated = false;
        foreach (GameObject aLink in artLinks)
        {
            Destroy(aLink);
        }
        artLinks.Clear();
    }

    #endregion

    #region Collider Trigger Events
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            for (int i = 0; i < artBorders.Length; i++)
            {
                artBorders[i].material = hightlightedBorderMat;
            }


            ShowButtonPanel();
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
            for (int i = 0; i < artBorders.Length; i++)
            {
                artBorders[i].material = normalBorderMat;
            }

            HideInfoPanel();
            HideButtonPanel();
            HideRelatedArtwork();
        }
    }
    #endregion Collider Trigger Events
}
