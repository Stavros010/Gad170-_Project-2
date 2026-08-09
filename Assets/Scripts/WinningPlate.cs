using TMPro;
using UnityEngine;


public class WinningPlate : MonoBehaviour
{
    public GameObject Player;

    public GameObject WinMessage; // the Image object on the canvas
    public TextMeshProUGUI WinMessageText; // the TMP text on that panel


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

// Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            WinMessageText.text = "You Win!!!";
            WinMessage.SetActive(true);
            Debug.Log("You Win");
        }
    }
}
