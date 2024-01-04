using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{

    private Collider2D myCollider;
    private Renderer objectRenderer;
    // Start is called before the first frame update
    void Start()
    {
        // Get the Collider2D component attached to the GameObject
        myCollider = GetComponent<Collider2D>();

        // Check if the Collider2D component exists
        if (myCollider == null)
        {
            Debug.LogError("Collider2D not found on GameObject: " + gameObject.name);
        }

        // Get the Renderer component attached to the GameObject
        objectRenderer = GetComponent<Renderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision involves a GameObject with the tag "Player"
        if (collision.gameObject.name == "MainCharacter")
        {
           myCollider.enabled = false;
           objectRenderer.enabled = false;
           SceneController.instance.NextLevel();
        }

        // Check if the collision involves a GameObject with the tag "Player"
        if (collision.gameObject.name == "Ground")
        {
           // Get the current scene index
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            // Reload the current scene
            SceneManager.LoadScene(currentSceneIndex);
        }
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
