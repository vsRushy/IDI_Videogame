using UnityEngine;

public class TimerPlayer : MonoBehaviour
{
    private float timer;
    private bool canCount;

	// Use this for initialization
	void Start ()
    {
        canCount = true;
        timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
        /*if(timer % 5.0f == 0.0f)
        {
            transform.localScale = new Vector3(transform.localScale.x - 0.1f, transform.localScale.y - 0.1f, transform.localScale.z);
        }*/
        if(timer > 2.0f && canCount)
        {
            transform.localScale = new Vector3(transform.localScale.x - 0.008f, transform.localScale.y - 0.008f, transform.localScale.z);
            canCount = false;
        }
	}
}
