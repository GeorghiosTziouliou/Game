using UnityEngine;
using UnityEngine.InputSystem;

public class Respawn : MonoBehaviour
{
    // The initial position where the player should respawn
    public Vector3 respawnPosition;

    // The action to trigger the respawn
    public InputAction respawnAction;

    // The parent object of the player components
    public GameObject playerParentObject;

    // Initialize the input action
    void Start()
    {
        respawnAction.Enable();
        respawnAction.performed += RespawnPlayer;
    }

    // Reset the player's position to the respawn position
    void RespawnPlayer(InputAction.CallbackContext context)
    {
        // Reset the position of the parent object (which holds the cameras)
        playerParentObject.transform.position = respawnPosition;

		Debug.Log("Respawned player");

        // Reset the position of the child object (the capsule or character model)
        transform.position = respawnPosition;
    }

    // Disable the input action when the script is destroyed
    void OnDestroy()
    {
        respawnAction.performed -= RespawnPlayer;
        respawnAction.Disable();
    }
}
