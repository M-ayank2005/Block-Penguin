using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchMiniGame : MonoBehaviour
{
    // Name of the scene containing the mini-game
    public string miniGameSceneName;

    // Method to launch the mini-game
    public void Launch()
    {
        // Load the scene containing the mini-game
        SceneManager.LoadScene(miniGameSceneName);
    }
}