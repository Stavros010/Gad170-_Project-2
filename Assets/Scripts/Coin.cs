using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float coinRotation = 100f;
    public int coinValue = 1;
    public GameObject coinMessage; // the Image object on the canvas
    public TextMeshProUGUI coinMessageText; // the TMP text on that panel
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * coinRotation * Time.deltaTime);
        //rotates hazard Continuously 
    }


    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            // MAKE SURE TO DO SAME THING AS MESSAGE UI TO CALL THE FUNTION TO THE COIN MANAGER
            coinMessageText.text = "+1";
            coinMessage.SetActive(true);
            // Destroy the hazard object immediately
            Destroy(gameObject);
        }
    }
}
