//this script is attached to game over panel

using System;
using UnityEngine;
using UnityEngine.UI;
public class win : MonoBehaviour
{
    public static Text gameOverText;
    public Text setgameOverText;

    public static Button jumpBtn, leftBtn, rightBtn;
    public Button setjunpBtn, setleftBtn, setrightBtn;

    public static GameObject folPlayerGameObj;
    public GameObject setfolPlayerGameObj;

    private void Start()
    {
        jumpBtn = setjunpBtn;
        leftBtn = setleftBtn;
        rightBtn = setrightBtn;
        folPlayerGameObj = setfolPlayerGameObj;
        gameOverText = setgameOverText;
    }

    public static void winGame()
    {
        //gameManage.isGameOver = true;
        Debug.Log("winGame is called");
        Destroy(gameOverText);
        gameOverMenu.showpanel();
        jumpBtn.gameObject.SetActive(false);
        leftBtn.gameObject.SetActive(false);
        rightBtn.gameObject.SetActive(false);
        folPlayerGameObj.GetComponent<followPlayer>().enabled = false;    //disable script followplayer
    }

    // private void Update()
    // {
    //     if(gameManage.hasWon)
    //         
    // }
}

