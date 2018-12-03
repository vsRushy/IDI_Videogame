using UnityEngine;
using UnityEngine.UI;

public class TimerPlayer : MonoBehaviour
{
    private int difficulty;
    private float reducing_time;

    // Use this for initialization
    void Start ()
    {
        difficulty = DifficultyNum.difficulty;
        switch (difficulty)
        {
            case 1:
                reducing_time = 0.0005f;
                break;
            case 2:
                reducing_time = 0.001f;
                break;
            case 3:
                reducing_time = 0.008f;
                break;
            default:
                break;
        }

        InvokeRepeating("ReduceScale", 0.0f, 4.0f);
    }
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    void ReduceScale()
    {
        transform.localScale = new Vector3(transform.localScale.x - reducing_time, transform.localScale.y - reducing_time, transform.localScale.z);
    }
}


