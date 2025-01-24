using UnityEngine;
using UnityEngine.UI;

public class Pants : MonoBehaviour
{
    public GameObject[] pants; 
    private int currentHairIndex = 0; 

    public Button leftButton; 
    public Button rightButton; 

    void Start()
    {
        // Initialize by showing the first hair style and hiding the others
        for (int i = 0; i < pants.Length; i++)
        {
            pants[i].SetActive(i == currentHairIndex); // Activate only the first hair style
        }

        // Add listeners to the buttons to call the respective methods when clicked
        leftButton.onClick.AddListener(DecreaseHair);
        rightButton.onClick.AddListener(IncreaseHair);
    }

    void DecreaseHair()
    {
        // Deactivate the current hair style
        pants[currentHairIndex].SetActive(false);

        // Update the index to the previous hair style
        currentHairIndex = (currentHairIndex - 1 + pants.Length) % pants.Length; // Wrap around using modulo

        // Activate the new current hair style
        pants[currentHairIndex].SetActive(true);
    }

    void IncreaseHair()
    {
        // Deactivate the current hair style
        pants[currentHairIndex].SetActive(false);

        // Update the index to the next hair style
        currentHairIndex = (currentHairIndex + 1) % pants.Length; // Wrap around using modulo

        // Activate the new current hair style
        pants[currentHairIndex].SetActive(true);
    }
}