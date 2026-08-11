using TMPro;
using UnityEngine;


public class WinningPlate : MonoBehaviour
{
    public GameObject Player;
    public Transform winPoint;
    public GameObject WinMessage; // the Image object on the canvas
    public TextMeshProUGUI WinMessageText; // the TMP text on that panel


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        WinMessage.SetActive(false);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            WinMessageText.text = "You Win!!!";
            WinMessage.SetActive(true);
            Debug.Log("You Win");

            Player.transform.position = winPoint.position; // teleporting the player to the respawn position
        }
        else
        {
            WinMessage.SetActive(false);
        }
    }
}
