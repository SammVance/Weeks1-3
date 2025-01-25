using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject newThing = Instantiate(prefab, mouse, Quaternion.identity); // spawn from mouse position

            //Instantiate(prefab, transform); // Spawn from parent position

            newThing.transform.localScale = Vector3.one * Random.Range(0.75f, 1.5f);
            FirstScript myScript = newThing.GetComponent<FirstScript>();

            if (myScript != null)
            {
                myScript.speed = Random.Range(1f, 5f);
            }

            // newThing.GetComponent<FirstScript>().speed = Random.Range(1f, 5f);
        }
    }
}
