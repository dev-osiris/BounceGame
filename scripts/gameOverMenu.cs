//this script is attached to game over panel

using UnityEngine;
using UnityEngine.UI;

public class gameOverMenu : MonoBehaviour
{
    public GameObject setPanel;
    public static GameObject panel;

    public Text setfinalScore;
    public static Text finalScore;

    public static Button pauseBtn;
    public Button setpauseBtn;
    void Start()
    {
        panel = setPanel;
        finalScore = setfinalScore;
        pauseBtn = setpauseBtn;
    }

    public static void showpanel()      //gameover panel
    {
        Debug.Log("showpanel is called");
        if(gameManage.hasWon)
            finalScore.text = "You Win!\nScore : " + coinCollect.score;
        finalScore.text = "Score : " + coinCollect.score;
        panel.gameObject.SetActive(true);
        pauseBtn.gameObject.SetActive(false);
    }
    public static void hidepanel()
    {
        //Debug.Log("hidepanal is called");
        panel.gameObject.SetActive(false);
        
    }

}
