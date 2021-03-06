using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public SpriteRenderer sr;

    public GameObject soul; // Prefab of the soul

    [SerializeField]
    public static float speed = 50.0f;

    [SerializeField]
    private float max_speed;

    public uint souls = 0;
    public static uint final_souls = 0;

    public AudioSource pop_effect;

    public static string color_name = "White";

    // Use this for initialization
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();

		for(int i = 0; i < EnemiesNum.enemies_number; i++)
		{
			Instantiate(soul, new Vector3(Random.Range(-18.5f, 18.5f), Random.Range(-10.0f, 10.0f), -9), Quaternion.identity);
		}

        pop_effect = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Change color
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            color_name = "White";
            sr.color = Color.white;
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            color_name = "Red";
            sr.color = Color.red;
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            color_name = "Blue";
            sr.color = Color.blue;
        }
        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            color_name = "Green";
            sr.color = Color.green;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        SetSpeed();
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Food")
        {
            pop_effect.Play();

            souls++;
            final_souls++;
            transform.localScale = new Vector3(transform.localScale.x + 0.008f, transform.localScale.y + 0.008f, transform.localScale.z);

            Destroy(c.gameObject);
            Instantiate(soul, new Vector3(Random.Range(-18.5f, 18.5f), Random.Range(-10.0f, 10.0f), 0), Quaternion.identity);
        }
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Spike")
        {
            Destroy(this.gameObject);
            TimerPlayer.game_end = 2;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    // ---------------------------
    public void Move()
    {
        // Add movement
        float h = Input.GetAxisRaw("Horizontal");
        rigidbody.AddForce(Vector2.right * speed * h * Time.deltaTime);

        float v = Input.GetAxisRaw("Vertical");
        rigidbody.AddForce(Vector2.up * speed * v * Time.deltaTime);

        LimitMovement();
    }

    public void LimitMovement()
    {
        if (rigidbody.velocity.x > max_speed)
        {
            rigidbody.velocity = new Vector2(max_speed, rigidbody.velocity.y);
        }
        if (rigidbody.velocity.x < -max_speed)
        {
            rigidbody.velocity = new Vector2(-max_speed, rigidbody.velocity.y);
        }

        if (rigidbody.velocity.y > max_speed)
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, max_speed);
        }
        if (rigidbody.velocity.y < -max_speed)
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, -max_speed);
        }
    }

    public void SetSpeed()
    {
        if(Input.GetKeyUp(KeyCode.KeypadPlus))
        {
            speed += 4;
        }
        if(Input.GetKeyUp(KeyCode.KeypadMinus))
        {
            speed -= 4;
        }
    }
}