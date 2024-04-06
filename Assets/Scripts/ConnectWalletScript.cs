using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectWalletScript : MonoBehaviour
{
    public GameObject connectPrompt;
    public CharaterMovementScript charaterMovementScript;
    // Start is called before the first frame update
    void Start()
    {
        connectPrompt.SetActive(true);
        charaterMovementScript.runSpeed = 0f;
    }

    // Update is called once per frame
    public void ConnectWallet(){
        connectPrompt.SetActive(false);
        charaterMovementScript.runSpeed = 40f;
    }

    public void showConnectPrompt(){
        connectPrompt.SetActive(true);
        charaterMovementScript.runSpeed = 0f;
    }

}
