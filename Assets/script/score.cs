using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public playerScript move;
    //public Transform player;
    public Text scoreText;
    public float timer = 0;

    // Update is called once per frame
    void Update()
    {
        if(move.enabled == true)
        {
            timer += .07f;
            scoreText.text = timer.ToString("0");
        }
    }
}
