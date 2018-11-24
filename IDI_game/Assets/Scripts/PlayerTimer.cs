﻿using UnityEngine;
using UnityEngine.UI;

public class PlayerTimer : MonoBehaviour {

    public Text counterText;

    public float seconds;

	// Use this for initialization
	void Start ()
    {
        counterText = GetComponent<Text>() as Text;
	}
	
	// Update is called once per frame
	void Update ()
    {
        seconds = (int)(Time.timeSinceLevelLoad);
        counterText.text = seconds.ToString("00");
	}
}
