using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardPress : MonoBehaviour
{
    public float speed = 5;
    float rotSpeed = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 pos = transform.position;
        //// Horizontal equals up and down, w and s
        //// Vertical equals left and right, a and d
        //// GetAxisRaw gets rid of the smoothing
        //pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

        //transform.position = pos;

        // Move the transform in the direction of that translation
        // Translate does everything above, just in one line of code
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);

        // Rotates the shape when pressing left or right
        // transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime);
    }
}
