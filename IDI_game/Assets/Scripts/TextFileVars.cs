using UnityEngine;

public class TextFileVars : MonoBehaviour
{
    string speed = "";
    string souls_generated = "";
    string souls_collected = "";

    string[] lines = { "Player Speed: ", "",
        "Number of souls generated: ", "",
        "Number of souls collected: ", "",
        "Player color: ", "",
        "Food color: ", "",
        "Win(1) / Lose(0)", ""
    };

    public void SetVariables()
    {
        speed = PlayerMovement.speed.ToString();
        lines[1] = this.speed;

        souls_generated = EnemiesNum.enemies_number.ToString();
        lines[3] = this.souls_generated;

        souls_collected = PlayerMovement.final_souls.ToString();
        lines[5] = this.souls_collected;

        System.IO.File.WriteAllLines(@"C:/Users/gerardmf2/Documents/GitHub/IDI_Videogame/IDI_game/Assets/variables.txt", lines);
    }
}
