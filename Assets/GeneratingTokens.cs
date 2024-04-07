using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratingTokens : MonoBehaviour
{
    [SerializeField] public TMPro.TextMeshProUGUI initialTokens; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void incrementCount()
    {
        initialTokens.text = "Gems: 100";
    }

    public void decrementCount()
    {
        initialTokens.text = "Gems: 0";
    }

}
