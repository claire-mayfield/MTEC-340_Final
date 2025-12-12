using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenuManager : MonoBehaviour
{
    public KeyCode StartGame;
    public KeyCode Instructions;
    public KeyCode QuitGame;

    void Update()
    {
        if (Input.GetKey(StartGame))
        {
            SceneManager.LoadScene("Tutorial");
        }
    }
}
