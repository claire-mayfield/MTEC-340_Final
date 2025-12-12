using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenuManager : MonoBehaviour
{
    public KeyCode StartGame;
    public KeyCode Instructions;
    public KeyCode ExitGame;

    void Update()
    {
        if (Input.GetKey(StartGame))
        {
            SceneManager.LoadScene("Tutorial");
        }
		
        if (Input.GetKey(ExitGame))
        {
            Application.Quit();
        }
    }
}
