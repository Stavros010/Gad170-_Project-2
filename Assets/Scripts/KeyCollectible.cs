using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class KeyCollectible : MonoBehaviour
{
    public bool hasKey;
    public float keyRotation = 100f;
    public GameObject pickupMessage; // the Image object on the canvas
    public TextMeshProUGUI pickupMessageText; // the TMP text on that panel
   // public float messageDuration = 3.0f; // Time in seconds
   // private bool hasInvoked = false;
    public void Start()
    {
        pickupMessage.SetActive(false);
    }
   void Update()
    {
        transform.Rotate(Vector3.right * keyRotation * Time.deltaTime);
        // Check if message is true and we haven't invoked yet
        //if (!gameObject && !hasInvoked)
        // {

        //  hasInvoked = true;

        // Call HideHideFunction after 2.0 seconds
        //  Invoke(nameof(HideMessage), 2.0f);
        // }
    }
    public void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();
            if (inventory != null)
            {
                inventory.hasKey = true;
                Debug.Log("Key Collected!");
                pickupMessageText.text = "Key has been Collected";
                pickupMessage.SetActive(true);

                //Destroy the gameobject in an amount of time 
                Destroy(pickupMessage, 3.0f);
            }
            else
            {
                Debug.Log("no inventory");
               
            }

            transform.SetParent(other.transform);
            gameObject.SetActive(false);
        }
        //else
       // {
           // Debug.Log("Not a Player");
       // }
    }

    //public void PickupKey()
   // {
       // if (pickupMessage.gameObject(true))
       // {
            // Calls HideMessage after displayDuration seconds
        //    Invoke("HideMessage", displayDuration);
            //Invoke used to execute a specific method after a timed delay
       // }
   // }

    public void HideMessage()
    {
        pickupMessage.SetActive(false);
    }
}

