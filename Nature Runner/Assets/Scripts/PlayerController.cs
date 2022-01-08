using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public float thrust = 10.0f;
    public LayerMask groundLayerMask; 
    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator.SetBool("isAlive", true);
    }

    // Update is called once per frame
    void Update()
    {
        bool isOnTheGround = IsOnTheGround();
        animator.SetBool("isGrounded", isOnTheGround);
        if((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) && isOnTheGround){
            Jump();
        }
    }

    void Jump()
    {
        if(IsOnTheGround() == true)
        {
            rb.AddForce(Vector3.up * thrust, ForceMode.Impulse);
        }
    }

    bool IsOnTheGround()
    {
        bool test = Physics.Raycast(transform.position, Vector3.down, 1.0f, groundLayerMask.value);
        Debug.Log(test);
        return test;
    }
}
