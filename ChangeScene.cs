//this script is attached to menu button and home button

using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public void playSceneLevel1()
    {
        gameManage.isGameOver = false;
        gameManage.livesLeft = true;
        SceneManager.LoadScene(2);
    }

    public void playSceneLevel2()
    {
        gameManage.isGameOver = false;
        gameManage.livesLeft = true;
        SceneManager.LoadScene(3);
    }

    public void playSceneLevels()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        gameManage.isGameOver = false;
        gameManage.isPaused = false;
    }

    public void playSceneLevel3()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1;
    }

    public void playSceneHome()
    {
        SceneManager.LoadScene(0);
        gameManage.isGameOver = false;
    }

    public void quitGame()
    {
        Application.Quit(0);
    }

}
