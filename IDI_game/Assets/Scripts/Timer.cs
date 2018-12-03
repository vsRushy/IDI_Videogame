using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	public Text counterText;

    public float timer;
    
	public static float seconds;
    public static float minutes;

	// Use this for initialization
	void Start()
	{
		counterText = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update()
	{
        timer += Time.deltaTime;
        minutes = Mathf.Floor(timer / 60.0f);
        seconds = timer % 60.0f;
        
        counterText.text = "Minutes: " + minutes.ToString("00") + " Seconds: " + seconds.ToString("00");
	}
}
