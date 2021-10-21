using UnityEngine.UI;
using UnityEngine;

public class CategoryButtonsHandler : MonoBehaviour
{
    [SerializeField] CategoryButton[] categoryButtons;

    public void SetSelectedButton(int buttonIndex)
    {
        foreach(CategoryButton btn in categoryButtons)
        {
            btn.SetUnselected();
        }

        categoryButtons[buttonIndex].SetSelected();
    }
}
