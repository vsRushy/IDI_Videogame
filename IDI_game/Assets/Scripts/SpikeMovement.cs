using UnityEngine;

public class SpikeMovement : MonoBehaviour
{
    private int difficulty;

    public Rigidbody2D rb;

    public float accelerationTime;
    public float maxSpeed = 5f;
    private Vector2 movement;
    private float timeLeft;

    void Start()
    {
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
    }

    void FixedUpdate()
    {
        rb.AddForce(movement * maxSpeed * Time.deltaTime);
    }
}
