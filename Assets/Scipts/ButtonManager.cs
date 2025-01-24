using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button mainButton; // Reference to the main button
    public Button[] additionalButtons; // Array to hold additional buttons

    void Start()
    {
        // Add a listener to the main button
        mainButton.onClick.AddListener(OnMainButtonClick);

        // Initially hide additional buttons
        foreach (Button button in additionalButtons)
        {
            button.gameObject.SetActive(false);
        }
    }

    void OnMainButtonClick()
    {
        // Show additional buttons when the main button is clicked
        foreach (Button button in additionalButtons)
        {
            button.gameObject.SetActive(true);
        }
    }
}