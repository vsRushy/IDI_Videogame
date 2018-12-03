using UnityEngine;
using UnityEngine.UI;

public class DifficultyNum : MonoBehaviour
{
    public Slider dif_slider;

    public static int difficulty;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        difficulty = (int)dif_slider.value;
    }
}
