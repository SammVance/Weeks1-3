using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMouseClick : MonoBehaviour
{
    public Vector2 mousePos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // If mouse button is pressed, move shape to mouse position
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePos;
        }
    }
}

