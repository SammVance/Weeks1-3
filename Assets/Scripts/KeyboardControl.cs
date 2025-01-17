using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControl : MonoBehaviour
{
    public float speed = 5;
    public float rotSpeed = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 pos = transform.position;

        //pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        // Input.GetAxisRaw does not smooth, much snappier

        //transform.position = pos;

        transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime);
        transform.Translate(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
    }
}
