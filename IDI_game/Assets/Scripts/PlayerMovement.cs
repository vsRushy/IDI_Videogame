using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody;

    [SerializeField]
    private float speed;

    [SerializeField]
    private float max_speed;

    // Player boundaries
    public bool bounds;
    public Vector3 minPlayerPos;
    public Vector3 maxPlayerPos;

    // Use this for initialization
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        PlayerBoundaries();
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Food")
        {
            transform.localScale = new Vector3(transform.localScale.x + 1.0f, transform.localScale.y + 1.0f, transform.localScale.z);

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

        //LimitMovement();
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

    public void PlayerBoundaries()
    {
        if (bounds)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minPlayerPos.x, maxPlayerPos.x),
                Mathf.Clamp(transform.position.y, minPlayerPos.y, maxPlayerPos.y),
                Mathf.Clamp(transform.position.z, minPlayerPos.z, maxPlayerPos.z));
        }
    }
}
