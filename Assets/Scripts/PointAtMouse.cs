using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAtMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Creating a variable to grab the position of the mouse
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0; // Make sure it ignores the z value because Vector3
        // Create direction variable which is equal to the mouse position compared to the shape's position
        Vector2 direction = mouse - transform.position;

        // Make the up vector face the direction of the mouse
        transform.up = direction;
    }
}
