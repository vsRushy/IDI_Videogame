using UnityEngine;

public class TextFileVars : MonoBehaviour
{
    string speed = "";
    string souls_generated = "";
    string souls_collected = "";
    string player_color = "";
    string spikes_color = "";
    string game_end = "";
    string minutes_played = "";
    string seconds_played = "";
    string difficulty = "";

    string[] lines = { "Player Speed: ", "",
        "Number of souls generated: ", "",
        "Number of souls collected: ", "",
        "Player color: ", "",
        "Spikes color: ", "",
        "Win(1) / Lose(2):", "",
        "Time played:", "",
        "Difficulty[1: easy, 2: normal, 3: hard]: ", ""
    };

    public void SetVariables()
    {
        speed = PlayerMovement.speed.ToString();
        lines[1] = this.speed;

        souls_generated = EnemiesNum.enemies_number.ToString();
        lines[3] = this.souls_generated;

        souls_collected = PlayerMovement.final_souls.ToString();
        lines[5] = this.souls_collected;

        player_color = PlayerMovement.color_name;
        lines[7] = this.player_color;

        spikes_color = SpikeMovement.spike_color;
        lines[9] = this.spikes_color;

        game_end = TimerPlayer.game_end.ToString();
        lines[11] = this.game_end;

        minutes_played = Timer.minutes.ToString();
        seconds_played = Timer.seconds.ToString();
        lines[13] = "Minutes: " + this.minutes_played + " Seconds: " + this.seconds_played;

        difficulty = DifficultyNum.difficulty.ToString();
        lines[15] = this.difficulty;

        System.IO.File.WriteAllLines(@"C:\Users\usuario\Documents\GitHub\IDI_Videogame\IDI_game\Assets\variables.txt", lines);
    }
}
