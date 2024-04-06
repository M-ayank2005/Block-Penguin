using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thirdweb;

public class TokenScript : MonoBehaviour
{
    public GemCollectScript gemCollectScript;

    public GameObject HasNotClaimedState;
    public GameObject ClaimingState;
    public GameObject HasClaimedState;
    private int gemsToClaim;
    [SerializeField] public TMPro.TextMeshProUGUI tokenBalanceText;
    [SerializeField] private TMPro.TextMeshProUGUI gemsEarnedText;

    private void Start()
    {
        // claimPrompt.SetActive(false);
        HasNotClaimedState.SetActive(true);
        ClaimingState.SetActive(false);
        HasClaimedState.SetActive(false);
        // Ensure gemsEarnedText is active initially
        gemsEarnedText.gameObject.SetActive(true);
    }

    private void Update()
    {
        gemsEarnedText.text = "Gems Earned: " + gemCollectScript.gems.ToString();
        gemsToClaim = gemCollectScript.gems;
    }
    // private const string DROP_ERC20_CONTRACT = "0xb188E28e86b547DBb6964d85795336859A0716c9";
    private const string DROP_ERC20_CONTRACT = "0x6C73214a20D6365534A4BD17Fd1a3B949CF6bfAA";


    // public async void GetTokenBalance()
    // {
    //     try
    //     {
    //         // This line is retreving the address of the user's wallet asynchronously
    //         var address = await ThirdwebManager.Instance.SDK.Wallet.GetAddress();

    //         // This line 
    //         Contract contract = ThirdwebManager.Instance.SDK.GetContract(DROP_ERC20_CONTRACT);
    //         var data = await contract.ERC20.BalanceOf(address);
    //         tokenBalanceText.text = "$GEM: " + data.displayValue;
    //     }
    //     catch (System.Exception ex)
    //     {
    //         Debug.Log("Error getting token balance: " + ex.Message);
    //     }
    // }

    public void ResetBalance()
    {
        tokenBalanceText.text = "$GEM: 0";
    }

    public async void GetTokenBalance()
    {
        try
        {
            // This line is retreving the address of the user's wallet asynchronously
            var address = await ThirdwebManager.Instance.SDK.Wallet.GetAddress();
            Debug.Log(address);

            // This line takes out our contract
            Contract contract = ThirdwebManager.Instance.SDK.GetContract(DROP_ERC20_CONTRACT);

            // This line extracts balance of ERC20 tokens from the contract and stores it in data
            var data = await contract.ERC20.BalanceOf(address);

            tokenBalanceText.text = "$GEM: " + data.displayValue;
        }
        catch (System.Exception ex)
        {
            Debug.Log("Error getting token balance." + ex);
        }
    }

    public async void MintERC20()
    {
        try
        {
            Debug.Log("Minting ERC20");
            Contract contract = ThirdwebManager.Instance.SDK.GetContract(DROP_ERC20_CONTRACT);
            Debug.Log(contract.ToString());
            HasNotClaimedState.SetActive(false);
            ClaimingState.SetActive(true);
            var tokensToMint = gemsToClaim.ToString();

            Debug.Log(tokensToMint);
            // var tx = await contract.ERC20.Claim(gemsToClaim.ToString());
            // var receipt = tx.receipt;
            var results = await contract.ERC20.Transfer("0x04aaf3463E0EfB2563eAfB8B8F6A0872617E5fe7", tokensToMint);
            Debug.Log("ERC20 minted");
            // Debug.Log(receipt);
            // GetTokenBalance();
            ClaimingState.SetActive(false);
            HasClaimedState.SetActive(true);

            // Debug.Log("Ho gaya Mint 1");
        }
        catch (System.Exception ex)
        {
            Debug.Log("Error minting ERC20 " + ex);
        }
    }
}

// public async void MintERC20()
// {
//     try
//     {
//         Debug.Log("Minting ERC20");

//         // Check if ThirdwebManager.Instance.SDK is null
//         if (ThirdwebManager.Instance.SDK == null)
//         {
//             Debug.LogError("ThirdwebManager.Instance.SDK is not initialized.");
//             return;
//         }

//         // Get the contract
//         Contract contract = ThirdwebManager.Instance.SDK.GetContract(DROP_ERC20_CONTRACT);

//         // Check if the contract is null
//         if (contract == null)
//         {
//             Debug.LogError("Failed to initialize contract.");
//             return;
//         }

//         // Check if contract.ERC20 is null
//         if (contract.ERC20 == null)
//         {
//             Debug.LogError("ERC20 interface is not available.");
//             return;
//         }

//         // Check if gemsToClaim is valid
//         if (gemsToClaim <= 0)
//         {
//             Debug.LogError("Invalid value for gemsToClaim.");
//             return;
//         }

//         HasNotClaimedState.SetActive(false);
//         ClaimingState.SetActive(true);

//         // Mint ERC20 tokens
//         var results = await contract.ERC20.Claim(gemsToClaim.ToString());
//         if (results == null)
//         {
//             Debug.LogError("Claim method returned null.");
//             return;
//         }

//         Debug.Log("ERC20 minted");

//         // Update token balance
//         GetTokenBalance();

//         ClaimingState.SetActive(false);
//         HasClaimedState.SetActive(true);
//     }
//     catch (System.Exception ex)
//     {
//         Debug.Log("Error minting ERC20: " + ex.Message);
//     }
// }