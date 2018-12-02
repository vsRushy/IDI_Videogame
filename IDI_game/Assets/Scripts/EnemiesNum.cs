using UnityEngine;
using UnityEngine.UI;

public class EnemiesNum : MonoBehaviour
{
    public InputField input_field;

    public static int enemies_number;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        enemies_number = int.Parse(input_field.text.ToString());
	}
}
