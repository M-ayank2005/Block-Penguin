using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGameButton : MonoBehaviour
{
    public void ExitMiniGame()
    {
        SceneManager.LoadScene("SC Pixel Art Top Down - Basic");
    }
}