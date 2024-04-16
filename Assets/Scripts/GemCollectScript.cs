using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollectScript : MonoBehaviour
{
    public int gems = 0;
    public GameObject claimPrompt;

    [SerializeField] private TMPro.TextMeshProUGUI gemScoreText;

    private void Start() {
        claimPrompt.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D collition) {
        if (collition.gameObject.CompareTag("Gem"))
        {
            Destroy(collition.gameObject);
            gems++;
            gemScoreText.text = gems.ToString();
        }
    }

    public void Update(){
        if (gems == 6)
        {
            claimPrompt.SetActive(true);
        }
    }

}
