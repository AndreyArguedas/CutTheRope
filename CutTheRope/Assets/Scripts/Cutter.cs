using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // Convert the mouse position to world coordinates
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Set the GameObject's position to the world mouse position
        transform.position = worldMousePosition;
		
    }
	

}
