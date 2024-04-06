using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class LaunchMiniGame : MonoBehaviour
{
    // Path to the executable file of the mini-game
    public string miniGameExecutablePath;

    public void Launch()
    {
        // Check if the path to the mini-game executable is not empty
        if (!string.IsNullOrEmpty(miniGameExecutablePath))
        {
            // Launch the mini-game executable using the Process class
            Process.Start(miniGameExecutablePath);
        }
    }
}

