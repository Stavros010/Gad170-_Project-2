using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class KeyCollectible : MonoBehaviour
{
    public bool hasKey;
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();
            if (inventory != null)
            {
                inventory.hasKey = true;
                Debug.Log("Key Collected!");
            }
            else
            {
                Debug.Log("no inventory");
            }

            transform.SetParent(other.transform);
            gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("Not a Player");
        }
    }
}
 