using UnityEngine;
using UnityEngine.UI;

public class SpeedText : MonoBehaviour
{
    public Text speedText;

    public PlayerMovement player_movement;

    // Use this for initialization
    void Start()
    {
        player_movement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        speedText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        speedText.text = "Speed: " + player_movement.speed.ToString();
    }
}
