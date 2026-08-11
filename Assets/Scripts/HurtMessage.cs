using TMPro;
using UnityEngine;

public class HurtMessage : MonoBehaviour
{
    public GameObject hurtMessage; // the Image object on the canvas
    public TextMeshProUGUI hurtMessageText; // the TMP text on that panel


    private void Start()
    {
        hurtMessage.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           
             
          hurtMessageText.text = "Spikes HURT, try to jump over";
          hurtMessage.SetActive(true);
          Debug.Log("Spikes HURT, Try to jump over");
            
        }
    }
    private void OnTriggerExit(Collider other)
    // makes sure message goes away after leaving trigger box
    {
        if (other.CompareTag("Player"))
        {
           hurtMessage.SetActive(false);
        }
    }
}
