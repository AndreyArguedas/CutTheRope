using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter : MonoBehaviour
{
    public GameObject objectToIgnore;

    void Start()
    {
        // Check if the GameObject with the specified tag exists
        if (objectToIgnore != null)
        {
            // Ignore collisions between this GameObject and the specified GameObject
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), objectToIgnore.GetComponent<Collider2D>(), true);
        }
        else
        {
            // Log a warning if the GameObject with the specified tag is not found
            Debug.LogWarning("GameObject to ignore not found.");
        }
    }
    // Update is called once per frame
    void Update()
    {
        // Convert the mouse position to world coordinates
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Set the GameObject's position to the world mouse position
        transform.position = worldMousePosition;
		
    }
	

}
