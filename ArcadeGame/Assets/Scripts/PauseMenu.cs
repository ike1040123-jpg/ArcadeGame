using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    private bool _isPaused;

    [SerializeField] private GameObject _pauseMenu;
    
    public void Pause(InputAction.CallbackContext ctx)
    {
        _isPaused = true;
        _pauseMenu.SetActive(true);

        Time.timeScale = 0;
    }

    public void Resume()
    {
        _isPaused = false;
        _pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    
    public void Toggle()
    {
        _isPaused = !_isPaused;
        _pauseMenu.SetActive(_isPaused);
        Time.timeScale = _isPaused ? 0 : 1;
    }
    
    public void Quit()
    {
        SceneManager.LoadScene("Title");
    }
}