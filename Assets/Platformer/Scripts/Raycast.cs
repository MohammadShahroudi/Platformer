using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class Raycast : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject questionBlockPrefab;

    public GameObject brickPrefab;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // First Approach
        // if (Input.GetMouseButtonDown(0))
        // {
        //     Destroy(brickPrefab);
        // }
        
        // Second Approach
        // bool hitBrick = false;
        // bool hitQuestionBlock = false;
        //  && Physics.Raycast(ray, out hit) && hit.collider.brickPrefab
        
		if (Input.GetMouseButtonDown(0))
        { 
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
			// Collision collision;
             
            if (Physics.Raycast(ray, out hit))
            {
				Debug.Log(hit);
                // GameObject hitObject = hit.collider.gameObject;
                
            }
         }
    }

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.CompareTag("Brick"))
        { 
			Debug.Log("Hit Brick!");
        }
        
        if (collider.gameObject.CompareTag("Question"))
        {
        	Debug.Log("Hit Question Block!");
        }
	}
}
