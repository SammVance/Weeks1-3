using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureMove : MonoBehaviour
{
    public float speed = 5f;
    public float maxHeight = 5f;
    public float minHeight = 1f;
    public float maxDistance = 5f;
    public float startPos = 0f;

    bool isMoving = false;
    Vector3 initialPos;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = new Vector3(transform.position.x, startPos, transform.position.z);
        transform.position = initialPos;
    }

    // Update is called once per frame
    void Update()
    {
        // Toggle movement when the mouse is clicked
        if (Input.GetMouseButtonDown(0))
        {
            isMoving = !isMoving;

            // Reset the position of the object when mouse is not clicked
            if (isMoving == false)
            {
                initialPos = transform.position;
            }
        }

        if (isMoving)
        {
            // Get the mouse position
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = transform.position.z; // Keep the z position the same

            // Calculate the distance between the object and the mouse
            float distance = Vector3.Distance(transform.position, mousePos);

            // Normalize the distance to a value between 0 and 1
            float normalizedDistance = distance / maxDistance;

            // Keep the normalized distance between 0 and 1
            if (normalizedDistance > 1f)
            {
                normalizedDistance = 1f;
            }
            else if (normalizedDistance < 0f)
            {
                normalizedDistance = 0f;
            }

            // Calculate the target vertical position using normalized distance
            float targetHeight = Mathf.Lerp(maxHeight, minHeight, normalizedDistance);

            // Move toward the mouse position using Lerp
            Vector3 targetPos = transform.position;
            targetPos.y = Mathf.Lerp(transform.position.y, targetHeight, speed * Time.deltaTime);

            transform.position = targetPos;
        }
    }
}