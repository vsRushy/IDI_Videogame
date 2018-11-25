using UnityEngine;

public class PlayerLightPos : MonoBehaviour
{
    public GameObject player;

	// Use this for initialization
	void Start ()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
    }
}
