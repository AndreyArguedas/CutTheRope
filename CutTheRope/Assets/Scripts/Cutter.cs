using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter : MonoBehaviour
{
	
	private bool slicing;
	private Collider cutCollider;
	public Vector2 direction {get; private set;}
	public float minSliceVelocity = 0.01f;
	private Camera mainCamera;
	
	void Awake(){
		mainCamera = Camera.main;
		cutCollider = GetComponent<Collider>();
	}
	
	void OnEnable(){
		StopSlicing();
	}
	
	void OnDisables(){
		StopSlicing();
	}
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
			StartSlicing();
		}
		else if(Input.GetMouseButtonUp(0)){
			StopSlicing();
		}
		else if(slicing){
			ContinueSlicing();
		}
		
    }
	
	void StartSlicing(){
		slicing = true;
		cutCollider.enabled = true;
		transform.position = mainCamera.ScreenToWorldPoint(Input.mousePosition);
	}
	
	void StopSlicing(){
		slicing = false;
		cutCollider.enabled = false;
	}
	
	void ContinueSlicing(){
		Vector2 newPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
		Vector2 direction = newPosition - (Vector2) transform.position;
		
		float velocity = direction.magnitude / Time.deltaTime;
		cutCollider.enabled = velocity > minSliceVelocity;
		
		transform.position = newPosition;
	}
}
