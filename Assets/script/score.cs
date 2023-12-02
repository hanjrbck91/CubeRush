using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    //public Transform player;
    public Text scoreText;
    public float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += .07f;
        scoreText.text = timer.ToString("0");
    }
}
