using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using TMPro;

public class Raycast : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject questionBlockPrefab;
    public GameObject brickPrefab;
	public GameObject goalPrefab;
	public GameObject poisonPrefab;
	public GameObject marioPrefab;

	public int coinCount = 0;
	public int pointCount = 000000;

	public TextMeshProUGUI coinText;
	public TextMeshProUGUI pointText; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
    }

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.CompareTag("Brick"))
        { 
			pointCount += 100;
			pointText.text = $"MARIO";
			pointText.text = $" {pointCount.ToString()}";
			Destroy(collider.gameObject);
        }
		if (collider.gameObject.CompareTag("Question"))
        {
        	// Debug.Log("Hit Question Block!");
			coinCount += 1;
			pointCount += 100;
			// pointCount += 1;
			coinText.text = $" x{coinCount.ToString()}";
			pointText.text = $"MARIO";
			pointText.text = $" {pointCount.ToString()}";
			// pointText.text = $" {pointCount.ToString()}";
        }
		if (collider.gameObject.CompareTag("Goal"))
		{
			Debug.Log("Goal!");
			collider.gameObject.SetActive(false);
		}
		if (collider.gameObject.CompareTag("Poison"))
		{
			Debug.Log("Too Bad!");
			collider.gameObject.SetActive(false);
		}
	}
}

/*
 *
		if (Input.GetMouseButtonDown(0))
        { 
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
             
            if (Physics.Raycast(ray, out hit))
            {
				// Debug.Log(hit);

				if (hit.collider.gameObject.CompareTag("Brick"))
        		{ 
					pointCount += 100;
					pointText.text = $"MARIO";
					pointText.text = $" {pointCount.ToString()}";
					Destroy(hit.collider.gameObject);
        		}
        
        		if (hit.collider.gameObject.CompareTag("Question"))
        		{
        			// Debug.Log("Hit Question Block!");
					coinCount += 1;
					pointCount += 100;
					// pointCount += 1;
					coinText.text = $" x{coinCount.ToString()}";
					pointText.text = $"MARIO";
					pointText.text = $" {pointCount.ToString()}";
					// pointText.text = $" {pointCount.ToString()}";
        		}
			}
         }
 */