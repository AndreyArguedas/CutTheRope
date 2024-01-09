using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    // Reference to the Rigidbody component
    private Rigidbody2D rb;

    // Gravity scale value you want to set
    public float gravityScaleValue = 0.1f;

    public GameObject ball;

    private Renderer objectRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody component attached to the GameObject
        rb = GetComponent<Rigidbody2D>();

        // Get the Renderer component attached to the GameObject
        objectRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This method is called when another collider enters the trigger collider.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Ball")
        {
            liftBubble();
        }
        if (other.name == "Cutter")
        {
            destroyBubble();
        }
    }

    private void destroyBubble()
    {
        objectRenderer.enabled = false;
        ball.GetComponent<Rigidbody2D>().gravityScale = 0.55f;
        Destroy(this);
    }

    private void liftBubble()
    {
        rb.gravityScale = -gravityScaleValue;
        ball.GetComponent<Rigidbody2D>().velocity = new Vector2(rb.velocity.x, 0);
        ball.GetComponent<Rigidbody2D>().transform.position = transform.position;
        ball.GetComponent<Rigidbody2D>().gravityScale = rb.gravityScale;

    }
}
