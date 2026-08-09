using UnityEngine;

public class Coin : MonoBehaviour
{
    public float coinRotation = 100f;
    public int coinValue = 1;
    public int currentCoins = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * coinRotation * Time.deltaTime);
        //rotates coin Continuously 
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            // MAKE SURE TO DO SAME THING AS MESSAGE UI TO CALL THE FUNTION TO THE COIN MANAGER

            // Destroy the coin object immediately
            Destroy(gameObject);
        }
    }

    public void AddCoins()
    {
        currentCoins += 1;

        
    }


}
