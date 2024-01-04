using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{	
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	
	void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision involves a GameObject with the tag "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
           KeepOnlyOneSibling();
		   Destroy(this);
        }
    }
	
	void KeepOnlyOneSibling()
    {
        // Get all siblings of the current GameObject
        Transform parentTransform = transform.parent;
        if (parentTransform != null)
        {
            int childCount = parentTransform.childCount;

            for (int i = 0; i < childCount; i++)
            {
                Transform child = parentTransform.GetChild(i);

                Destroy(child.gameObject);
            }
        }
        else
        {
            Debug.LogWarning("This GameObject has no parent, cannot delete siblings.");
        }
    }
}
