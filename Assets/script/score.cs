using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public playerScript move;
    //public Transform player;
    public Text scoreText;
    public float timer = 0;

    void Start()
    {
        if (move.enabled)
        {
            InvokeRepeating("UpdateSound", 20, 20); // Invoke UpdateSound every 10 seconds, starting after 5 seconds
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(move.enabled == true)
        {
            timer += 10f * Time.deltaTime;

            scoreText.text = timer.ToString("0");
        }
    }

    void UpdateSound()
    {
        SoundManager.instance.UpdateLevelSound();
    }
}
