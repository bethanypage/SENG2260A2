using UnityEngine;

public class UIButtonHandler : MonoBehaviour
{
    Panel[] panels;

    void Start()
    {
        panels = GetComponentsInChildren<Panel>();

        foreach(Panel panel in panels)
        {
            panel.SetActive(false);
        }
    }

    public void TogglePanel(Panel panel)
    {
        
        panel.TogglePanel();
    }

    public void ShowPanel(Panel panel)
    {
        if (!panel.isActive) { panel.SetActive(true); }
    }

    public void HidePanel(Panel panel)
    {
        if (panel.isActive) { panel.SetActive(false); }
    }

    public void ShowButton(GameObject button)
    {
        button.SetActive(true);
    }

    public void HideButton(GameObject button)
    {
        button.SetActive(false);
    }
}
