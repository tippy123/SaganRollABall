
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    //will change our scene to the string passed in
    public void ChangeScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }

    //Redloads the current scene we are in
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //Loads out Title scene. Must be called Title exactly
    public void ToTitleScene()
    {
        SceneManager.LoadScene("Title");
    }

    //Gets our active scenes name 
    public string GetSceneName()
    {
        return SceneManager.GetActiveScene().name;
    }

    //Quits our game
    public void QuitGame()
    {
      Application.Quit();
    }
}
   

      
