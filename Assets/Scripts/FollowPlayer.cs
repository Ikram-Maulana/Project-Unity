using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform position kamera samakan dengan position player + vector3 dari si kamera
        transform.position = player.transform.position + new Vector3(0, 5, -7);
    }
}
