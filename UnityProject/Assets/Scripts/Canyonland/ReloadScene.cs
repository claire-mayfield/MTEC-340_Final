using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.Audio;

public class ReloadScene : MonoBehaviour
{
    public KeyCode RestartGame;
	public KeyCode MainMenu;
	
	void Start()
	{
		string Canyonland = SceneManager.GetActiveScene().name;
	}
	

    void Update()
    {
        if (Input.GetKey(RestartGame))
        {
            SceneManager.LoadScene("Canyonland");
        }
		
        if (Input.GetKey(MainMenu))
        {
            SceneManager.LoadScene("MainMenu");
        }
		

    }
}
