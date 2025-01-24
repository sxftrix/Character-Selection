using UnityEngine;
using UnityEngine.UI;

public class HairStyle : MonoBehaviour
{
    public GameObject[] hairStyles; // Array to hold the hair styles
    private int currentHairIndex = 0; // Index to track the current hair style

    public Button leftButton; // Reference to the button that will decrease the hair index
    public Button rightButton; // Reference to the button that will increase the hair index

    void Start()
    {
        // Initialize by showing the first hair style and hiding the others
        for (int i = 0; i < hairStyles.Length; i++)
        {
            hairStyles[i].SetActive(i == currentHairIndex); // Activate only the first hair style
        }

        // Add listeners to the buttons to call the respective methods when clicked
        leftButton.onClick.AddListener(DecreaseHair);
        rightButton.onClick.AddListener(IncreaseHair);
    }

    void DecreaseHair()
    {
        // Deactivate the current hair style
        hairStyles[currentHairIndex].SetActive(false);

        // Update the index to the previous hair style
        currentHairIndex = (currentHairIndex - 1 + hairStyles.Length) % hairStyles.Length; // Wrap around using modulo

        // Activate the new current hair style
        hairStyles[currentHairIndex].SetActive(true);
    }

    void IncreaseHair()
    {
        // Deactivate the current hair style
        hairStyles[currentHairIndex].SetActive(false);

        // Update the index to the next hair style
        currentHairIndex = (currentHairIndex + 1) % hairStyles.Length; // Wrap around using modulo

        // Activate the new current hair style
        hairStyles[currentHairIndex].SetActive(true);
    }
}