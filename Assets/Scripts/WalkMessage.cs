using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class WalkMessage : MonoBehaviour
{
    public GameObject walkMessage; 
    public TextMeshProUGUI walkMessageText; 

    private void Start()
    {
        // Show the controls message as soon as the scene starts
        walkMessageText.text = "W to walk forward, A to walk left, D to walk right, S to move backwards, Space to jump.";
        walkMessage.SetActive(true);
    }

    private void Update()
    {
        // Hide the message the moment the player uses any movement key
        // use || as an 'or' statement
        if (Keyboard.current.wKey.isPressed || Keyboard.current.aKey.isPressed || Keyboard.current.sKey.isPressed || Keyboard.current.dKey.isPressed || Keyboard.current.spaceKey.isPressed)
        {
            walkMessage.SetActive(false);
        }
    }
}
