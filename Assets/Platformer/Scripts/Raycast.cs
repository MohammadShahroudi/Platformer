using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using TMPro;

public class Raycast : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject questionBlockPrefab;

    public GameObject brickPrefab;

	public int coinCount = 0;

	public TextMeshProUGUI coinText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(0))
        { 
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
			// Collision collision;
             
            if (Physics.Raycast(ray, out hit))
            {
				Debug.Log(hit);

				if (hit.collider.gameObject.CompareTag("Brick"))
        		{ 
					Destroy(hit.collider.gameObject);
        		}
        
        		if (hit.collider.gameObject.CompareTag("Question"))
        		{
        			// Debug.Log("Hit Question Block!");
					coinCount += 1;
					coinText.text = $" x{coinCount.ToString()}";
        		}
			}
         }
    }
}
