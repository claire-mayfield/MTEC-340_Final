using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    public KeyCode LoadCanyonland;
    public KeyCode LoadMainMenu;
    public KeyCode QuitGame;

    void Update()
    {
        if (Input.GetKey(LoadCanyonland))
        {
            SceneManager.LoadScene("Canyonland");
        }
		
        if (Input.GetKey(LoadMainMenu))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
