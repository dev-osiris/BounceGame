//this script is attached to pause panel

using UnityEngine.UI;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public static GameObject pausePanel;
    public GameObject setpausePanel;

    public static Text pauseScoreText;
    public Text setpauseScoreText;

    void Start()
    {
        pausePanel = setpausePanel;
        pauseScoreText = setpauseScoreText;

    }

    public static void showPausePanel()
    {
        pauseScoreText.text = "Score : " + coinCollect.score.ToString();
        pausePanel.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public static void hidePausePanel()
    {
        pausePanel.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    
}
