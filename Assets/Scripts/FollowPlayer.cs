using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Public Variables to be use by another classes and on Unity
    public GameObject player;

    // Private Variables to be use only in this FollowPlayer class and not on Unity
    private Vector3 offsetCam = new Vector3(0, 6, -10);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate is called once per frame after the Update of the PlayerController
    void LateUpdate()
    {
        // Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offsetCam;
        
    }
}
