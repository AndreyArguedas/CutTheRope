using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cushion : MonoBehaviour 
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // This method is called when the object is clicked
    private void OnMouseDown()
    {
        Debug.Log("GameObject clicked: " + gameObject.name);
        // Iterate through all children of the parent
        foreach (Transform child in transform)
        {
            // Activate the child GameObject
            child.gameObject.SetActive(true);
        }
    }

    // This method is called when the object is clicked
    private void OnMouseUp()
    {
        foreach (Transform child in transform)
        {
            // Deactivate the child GameObject
            child.gameObject.SetActive(false);
        }
    }
}
