using UnityEngine;
using UnityEngine.UI;

public class CharSelButton : MonoBehaviour
{
    public Button buttonToClick; 
    public Button buttonToDisappear; 

    void Start()
    {
        buttonToClick.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        // Hide the button that will disappear when the other button is clicked
        buttonToDisappear.gameObject.SetActive(false);
    }
}