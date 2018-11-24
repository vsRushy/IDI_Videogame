using UnityEngine;
using UnityEngine.UI;

public class SoulCounter : MonoBehaviour
{
    public Text soulText;

    public PlayerMovement playermovement;

	// Use this for initialization
	void Start ()
    {
        playermovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        soulText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        soulText.text = "Number of souls: " + playermovement.souls.ToString();
	}
}
