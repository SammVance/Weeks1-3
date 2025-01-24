using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureMove : MonoBehaviour
{
    [Range(0, 1)]
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 height = transform.position;
        height.y = Mathf.Lerp(0, 1, t);

        transform.position = height;
    }
}
