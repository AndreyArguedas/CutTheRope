using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private Animator animator;
    private Collider2D myCollider;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Animator component attached to the GameObject
        animator = GetComponent<Animator>();

        if (animator == null)
        {
            Debug.LogError("Animator not found on GameObject: " + gameObject.name);
        }

        // Get the Collider2D component attached to the GameObject
        myCollider = GetComponent<Collider2D>();

        // Check if the Collider2D component exists
        if (myCollider == null)
        {
            Debug.LogError("Collider2D not found on GameObject: " + gameObject.name);
        }
    }

    // This method is called when another collider enters the trigger collider.
    /*private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Object found: " + other.name);
        if (other.name == "Ball")
        {
            // Trigger the animation by setting the parameter
            animator.SetTrigger("BiteCollision");
        }
    }*/

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision enter from main character: " + collision.gameObject.name);
        // Check if the collision involves a GameObject with the tag "Player"
        if (collision.gameObject.name == "Ball")
        {
           myCollider.enabled = false;
           //objectRenderer.enabled = false;
           animator.SetTrigger("BiteCollision");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
