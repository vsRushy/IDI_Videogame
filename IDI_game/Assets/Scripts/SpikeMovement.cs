using UnityEngine;

public class SpikeMovement : MonoBehaviour
{
    private int difficulty;

    public Rigidbody2D rb;
    public SpriteRenderer sr;

    public float accelerationTime;
    public float maxSpeed = 5f;
    private Vector2 movement;
    private float timeLeft;

    public static string spike_color = "White";

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        difficulty = DifficultyNum.difficulty;
        switch(difficulty)
        {
            case 1:
                accelerationTime = 5f;
                maxSpeed = 8f;
                break;
            case 2:
                accelerationTime = 9f;
                maxSpeed = 12f;
                break;
            case 3:
                accelerationTime = 11f;
                maxSpeed = 16f;
                break;
            default:
                break;
        }
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeLeft += accelerationTime;
        }

        // Change color
        if(Input.GetKeyUp(KeyCode.Keypad1))
        {
            spike_color = "White";
            sr.color = Color.white;
        }
        if (Input.GetKeyUp(KeyCode.Keypad2))
        {
            spike_color = "Red";
            sr.color = Color.red;
        }
        if (Input.GetKeyUp(KeyCode.Keypad3))
        {
            spike_color = "Blue";
            sr.color = Color.blue;
        }
        if (Input.GetKeyUp(KeyCode.Keypad4))
        {
            spike_color = "Green";
            sr.color = Color.green;
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(movement * maxSpeed * Time.deltaTime);
    }
}
