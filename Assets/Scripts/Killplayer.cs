
using UnityEngine;

public class Killplayer : MonoBehaviour
{
    public GameObject Player;
    public Transform respawnPoint;
    
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
            Player.transform.position = respawnPoint.position; // teleporting the player to the respawn position
        }
    }
}

