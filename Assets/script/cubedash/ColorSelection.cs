using UnityEngine;
using UnityEngine.UI;

public class ColorSelection : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] ColorData colorData;

    public void OnButtonClick()
    {
        if (cube != null && colorData != null)
        {
            Image buttonImage = GetComponent<Image>();
            if (buttonImage != null)
            {
                // Set the cube's color to the button's color
                cube.GetComponent<Renderer>().material.color = buttonImage.color;

                // Set the color in the ScriptableObject
                colorData.cubeColor = buttonImage.color;

                // Log the color change
                Debug.Log("Cube color changed: " + buttonImage.color);
            }
            else
            {
                Debug.LogWarning("Button does not have an Image component.");
            }
        }
        else
        {
            Debug.LogWarning("Cube reference or ColorData reference is not set.");
        }
    }
}