using UnityEngine;

public class TimerPlayer : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("ReduceScale", 0.0f, 4.0f);
    }
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    void ReduceScale()
    {
        transform.localScale = new Vector3(transform.localScale.x - 0.008f, transform.localScale.y - 0.008f, transform.localScale.z);
    }
}


