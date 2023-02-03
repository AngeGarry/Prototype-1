using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    // Public Variables to be use by another classes and on Unity
    public GameObject plane;

    // Private Variables to be use only in this FollowPlayerX class and not on Unity
    private Vector3 offset = new Vector3(15, 2, 0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
