using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class FlashlightControl : MonoBehaviour
{
    bool isActive = false;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // Grab the sprite
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Sprite starts invisible
        spriteRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Check for mouse clicks
        if (Input.GetMouseButtonDown(0))
        {
            // Toggle the active state of the flashlight
            isActive = !isActive; 

            // Update the visibility of the sprite
            spriteRenderer.enabled = isActive;

            // If toggled on, move to the mouse position
            if (isActive)
            {
                MoveToMouse();
            }
        }

        // If active, follow the mouse
        if (isActive)
        {
            MoveToMouse();
        }
    }

    void MoveToMouse()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        transform.position = mousePos;
    }
}
