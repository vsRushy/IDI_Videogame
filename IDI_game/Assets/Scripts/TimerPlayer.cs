using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerPlayer : MonoBehaviour
{
    private int difficulty;
    private float reducing_time;

    public static int game_end = 0; // 0 NULL, 1 win, 2 lose

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
        // Check if player reaches minimum size to end the game
        Vector3 temp_size = transform.localScale;
        if(temp_size.x < 0.0f)
        {
            game_end = 2;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        // Check if player reaches maximum size to win the game
        else if(temp_size.x > 5.0f)
        {
            game_end = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
	}

    void ReduceScale()
    {
        transform.localScale = new Vector3(transform.localScale.x - reducing_time, transform.localScale.y - reducing_time, transform.localScale.z);
    }
}


