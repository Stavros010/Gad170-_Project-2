using TMPro;
using UnityEngine;

public class DoorLocked : MonoBehaviour
{
    public GameObject door;

    public GameObject doorMessage; // the Image object on the canvas
    public TextMeshProUGUI doorMessageText; // the TMP text on that panel

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();

            if (inventory != null && inventory.hasKey)
            // Check that the player has an inventory component and that it contains the key
            {
                Debug.Log("Door unlocked!");
                Destroy(door);
            }
            else
            {
                doorMessageText.text = "The door is locked. You need a key.";
                doorMessage.SetActive(true);
                Debug.Log("The door is locked. You need a key.");
            }
        }
    }
    private void OnTriggerExit(Collider other)
        // makes sure message goes away after leaving trigger box
    {
        if (other.CompareTag("Player"))
        {
            doorMessage.SetActive(false);
        }
    }
}
