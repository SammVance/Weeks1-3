using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveAcrossScreen : MonoBehaviour
{
    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Move shape across the x-axis
       Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;

        // Where the square is within the screen
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        // Are you at the edge of the screen? If so, turn around
        if (screenPos.x < 0)
        {
            // Places the shape back inside the world screen
            Vector3 fixedPos = new Vector3(0, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }
        if (screenPos.x > Screen.width)
        {
            Vector3 fixedPos = new Vector3(Screen.width, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }

        transform.position = pos;
    }
}
