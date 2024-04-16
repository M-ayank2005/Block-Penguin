using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public Transform character; // Reference to the character's transform

    void Update()
    {
        // Check if the character falls out of the screen
        if (character.position.y < -5.0f) // Adjust the value as needed based on your game's screen dimensions
        {
            gameOver(); // Call the gameOver function if the character falls out of the screen
        }
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() { 
        gameOverScreen.SetActive(true);
    }

}