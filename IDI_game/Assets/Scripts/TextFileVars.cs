using UnityEngine;

public class TextFileVars : MonoBehaviour
{

    string speed = "";

    string[] lines = { "Player Speed: ", "", "Number of seeds: ", "", "Player Color: ", "", "Food color: " };

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    public void SetVariables()
    {
        speed = PlayerMovement.speed.ToString();
        lines[1] = this.speed;

        System.IO.File.WriteAllLines(@"C:/Users/gerardmf2/Documents/GitHub/IDI_Videogame/IDI_game/Assets/variables.txt", lines);
    }
}
