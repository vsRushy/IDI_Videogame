using UnityEngine;

public class SpikeSript : MonoBehaviour
{
    public GameObject spike;
    public uint num_spikes;

	// Use this for initialization
	void Start ()
    {
		for(int i = 0; i < num_spikes; i++)
        {
            Instantiate(spike, new Vector3(Random.Range(-18.5f, 18.5f), Random.Range(-10.0f, 10.0f), -1), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
