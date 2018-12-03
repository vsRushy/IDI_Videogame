using UnityEngine;
using TMPro;

public class SoulCountEndText : MonoBehaviour
{
    public TMP_Text soulEndCountText;

	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        soulEndCountText.text = PlayerMovement.final_souls.ToString();
    }
}
