using UnityEngine;
using UnityEngine.UI;

public class SpeedText : MonoBehaviour
{
    public Text speedText;

    // Use this for initialization
    void Start()
    {
        speedText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        speedText.text = "Speed: " + PlayerMovement.speed.ToString();
    }
}
