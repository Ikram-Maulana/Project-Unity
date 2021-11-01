using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;

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

        // Cara atur kecepatan sesuai time untuk menambah kecepatan * 10 
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
