using UnityEngine;
using TMPro;

public class Win_Lose_Txt : MonoBehaviour
{
    public TMP_Text win_lose_text;

    // Use this for initialization
    void Start()
    {
        switch (TimerPlayer.game_end)
        {
            case 1:
                win_lose_text.text = "You win";
                break;
            case 2:
                win_lose_text.text = "You lose";
                break;
            default:
                break;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
