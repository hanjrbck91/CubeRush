using UnityEngine;
using UnityEngine.UI;

public class MobileUIController : MonoBehaviour
{
    public playerScript player; // Drag and drop your playerScript reference in the inspector

    public void OnLeftButtonPressed()
    {
        player.MoveLeft();
    }

    public void OnRightButtonPressed()
    {
        player.MoveRight();
    }
}
