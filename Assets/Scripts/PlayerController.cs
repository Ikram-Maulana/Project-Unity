using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Hello World");

        // Cara merubah position .Translate(x, y, z);
        // transform.Translate(0, 0, 1);
        // Atau dengan
        // transform.Translate(Vector3.forward);

        // Get user vertical input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Cara atur kecepatan sesuai time untuk menambah kecepatan * 10 
        // transform.Translate(Vector3.forward * Time.deltaTime * speed);

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if(Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
