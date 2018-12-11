using UnityEngine;

public class TextFileVars : MonoBehaviour
{

    int speed = 5;

    string[] lines = { "Player Speed: ", "", "Number of seeds: ", "", "Player Color: ", "", "Food color: " };

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    public void SetVariables()
    {

        lines[1] = speed.ToString();
        System.IO.File.WriteAllLines(@"C:/Users/gerardmf2/Documents/GitHub/IDI_Videogame/IDI_game/Assets/variables.txt", lines);
    }
}
