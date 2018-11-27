using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	Vector3 velocity = Vector3.zero;
	public float smoothTime;

	public GameObject player;

	// Camera boundaries
	public bool bounds;
	public Vector3 minCameraPos;
	public Vector3 maxCameraPos;

	// Use this for initialization
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}

	void FixedUpdate()
	{
		Vector3 targetPos = player.transform.position;
		targetPos.z = transform.position.z;
		transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);

		if (bounds)
		{
			transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCameraPos.x, maxCameraPos.x),
				Mathf.Clamp(transform.position.y, minCameraPos.y, maxCameraPos.y),
				Mathf.Clamp(transform.position.z, minCameraPos.z, maxCameraPos.z));
		}
	}
}
