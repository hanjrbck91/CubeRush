using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerCollosion : MonoBehaviour
{
    [SerializeField] GameObject gameoverPanel;
    public playerScript movement;
    public score playerScore;
    public Text finalScore;
    public Text highScoreText; // Use a separate variable for high score value

    private void Start()
    {
        // Assign the highScoreText separately
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // This function runs when we hit another object.
    // We get information about the collision and call it "collisionInfo".
    void OnCollisionEnter(Collision collisionInfo)
    {
        // We check if the object we collided with has a tag called "Obstacle".
        if (collisionInfo.collider.tag == "obstacle")
        {
            int currentScore = int.Parse(playerScore.scoreText.text);

            finalScore.text = currentScore.ToString();

            int highScore = PlayerPrefs.GetInt("HighScore", 0);

            if (currentScore > highScore)
            {
                // Update the high score
                highScore = currentScore;
                PlayerPrefs.SetInt("HighScore", highScore);
                highScoreText.text = highScore.ToString();
            }

            movement.enabled = false;
            gameoverPanel.SetActive(true);
            // Disable the player's movement.
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
