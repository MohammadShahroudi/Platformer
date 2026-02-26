using TMPro;
using UnityEngine;


public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public GameObject goalPrefab;
	public GameObject marioPrefab;

    float timeLeft = 15;
	private bool timerRunning = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void StartTimer()
    {
	    timerRunning = true;
    }
    
    public void StopTimer()
    {
	    timerRunning = false;
    }
    
    void OnTriggerEnter(Collider collider)
    {
	    if (collider.gameObject.CompareTag("Goal"))
	    {
		    Debug.Log("Goal!");
		    collider.gameObject.SetActive(false);
		    StopTimer();
	    }
    }

    // Update is called once per frame
    void Update()
    {
		if (timerRunning)
		{
			timeLeft -= Time.deltaTime;
        	timeText.text = $"TIME\n {((int)timeLeft).ToString()}";
		}
        
		if (timeLeft <= 0)
        {
			Debug.Log("TIMES UP!");
			Destroy(marioPrefab);
			StopTimer();
        }
    }
}
