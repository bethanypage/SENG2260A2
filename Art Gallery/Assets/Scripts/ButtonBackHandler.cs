using UnityEngine;
using UnityEngine.UI;

public class ButtonBackHandler : MonoBehaviour
{
    public Image buttonBackImage;


    private void Awake()
    {
        if (buttonBackImage == null) { buttonBackImage = GetComponent<Image>(); }
    }

    public void ToggleButtonBack()
    {
        bool isVisible = buttonBackImage.enabled;

        buttonBackImage.enabled = !isVisible;
    }
}
