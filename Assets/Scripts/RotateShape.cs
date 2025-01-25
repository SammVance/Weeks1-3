using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RotateShape : MonoBehaviour
{
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // eulerAngels = rotate
        // Vector3 rot = transform.eulerAngles;
        // positive rotates counter clockwise, negative rotates clockwise
        // rot.z += 1;
        // transform.eulerAngles = rot;

        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
