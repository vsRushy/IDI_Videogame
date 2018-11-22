using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody;

    [SerializeField]
    private float speed = 0.0f;

    [SerializeField]
    private float max_speed = 0.0f;

    // Use this for initialization
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

	// Update is called once per frame
	void FixedUpdate ()
    {
        Move();
	}

    void OnTriggerEnter2D(Collider2D c)
    {
        if(c.gameObject.tag == "Food")
        {
            transform.localScale = new Vector3(transform.localScale.x + 0.02f, transform.localScale.y + 0.02f, transform.localScale.z);

            Destroy(c.gameObject);
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

        // Limit movement
        if(rigidbody.velocity.x > max_speed)
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
}
