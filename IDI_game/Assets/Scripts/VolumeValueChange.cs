using UnityEngine;

public class VolumeValueChange : MonoBehaviour
{
    private AudioSource music;

    private float music_volume = 1.0f;

	// Use this for initialization
	void Start ()
    {
        music = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        music.volume = music_volume;
	}

    public void SetVolume(float volume)
    {
        music_volume = volume;
    }
}
