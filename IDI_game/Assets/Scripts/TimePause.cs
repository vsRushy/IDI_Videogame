using UnityEngine;

public class TimePause : MonoBehaviour
{
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            else Time.timeScale = 1;
        }
	}
}
