using UnityEngine;
using UnityEngine.UI;

public class CategoryButton : MonoBehaviour
{
    [SerializeField] bool defaultSelected;
    [HideInInspector] public bool isSelected;
    [SerializeField] Color selectedColor;
    [SerializeField] Color unselectedColor;
    Image buttonImage;

    private void Awake()
    {
        buttonImage = GetComponent<Image>();
        if (defaultSelected) 
        { 
            SetSelected(); 
        }
        else
        {
            SetUnselected();
        }
    }

    public void SetSelected()
    {
        isSelected = true;
        buttonImage.color = selectedColor;
    }

    public void SetUnselected()
    {
        isSelected = false;
        buttonImage.color = unselectedColor;
    }
}
