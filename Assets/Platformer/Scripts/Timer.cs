using TMPro;
using UnityEngine;


public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public GameObject goalPrefab;

    float timeLeft = 5;
	private bool timerRunning = false;

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
		    // Debug.Log("Goal!");
		    collider.gameObject.SetActive(false);
		    StopTimer();
	    }
    }

    // Update is called once per frame
    void Update()
    {
	    StartTimer();
        timeLeft -= Time.deltaTime;
        timeText.text = $"TIME\n {((int)timeLeft).ToString()}";

		if (timeLeft <= 0)
        {
			Debug.Log("TIMES UP!");
			StopTimer();
        }
    }
}
