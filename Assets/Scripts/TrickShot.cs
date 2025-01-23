using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class TrickShot : MonoBehaviour
{
    public float speed = 1f;

    public AnimationCurve curve;

    [Range(0, 1)]
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed * Time.deltaTime;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < 0)
        {
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            t += Time.deltaTime;
            transform.position = Vector2.up * curve.Evaluate(t);

            if (t > 1)
            {
                t = 0;
            }
            
        }
    }
}

