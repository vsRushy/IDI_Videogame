using UnityEngine;
using TMPro;

public class TimePlayedEndText : MonoBehaviour
{
    public TMP_Text timePlayedEndText;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timePlayedEndText.text = Timer.minutes.ToString("00") + " min " + Timer.seconds.ToString("00") + " sec";
    }
}
