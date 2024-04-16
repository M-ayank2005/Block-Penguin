using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popUpLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject G;
    [SerializeField] public TMPro.TextMeshProUGUI balance;
    void Start()
    {
        G.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void popUp()
    {
        G.SetActive(true);
        balance.text = "Gems: 0";
    }

    public void closePopUp()
    {
        G.SetActive(false);
    }

    public void gemGamePopUp()
    {
        balance.text = "Gems: 6";
    }
}
