//this script is attached to player

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class gameManage : MonoBehaviour
{
    public Rigidbody2D player;
    public static bool isGameOver, isPaused, hasDrowned, hasWon, livesLeft;
    public Text finalScore;
    public static int numOfLivesLeft = 4;

    private void Start()
    {
        hasDrowned = false;
        isGameOver = false;
        livesLeft = true;
    }

    private void freezePlayer()
    {
        player.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemyBox") || collision.gameObject.CompareTag("enemySpikes"))
        {           
            isGameOver = true;
            freezePlayer();
            numOfLivesLeft--;
        }

        if (collision.gameObject.CompareTag("flagGreen"))   //WIN
        {
            Debug.Log("collided with flagGreen");
            Destroy(collision.gameObject);
            hasWon = true;
            win.winGame();
        }

        if (collision.gameObject.CompareTag("checkpoint"))
        {
            Debug.Log("crossed checkpoint");
            checkpoint.hasChecked = true;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("drownBar"))
        {
            Debug.Log("player drowned");
            isGameOver = true;
            hasDrowned = true;
            freezePlayer();
            numOfLivesLeft--;
        }
    }

    public void pause()
    {
        Debug.Log("pause is called");
        isPaused = true;
        pauseMenu.showPausePanel();
    }

    public void play ()     //unPause game
    {
        Debug.Log("play is called");
        isPaused = false;
        pauseMenu.hidePausePanel();
    }

    public static void replay()        //restart from beginning
    {
        Debug.Log("replay is called");
        isPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        isGameOver = false;
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (numOfLivesLeft == 0)
        {
            Debug.Log("all lives exhausted");
            livesLeft = false;
            gameOverMenu.showpanel();
        }

        if (!isPaused)
            pauseMenu.hidePausePanel();
        if (!isGameOver && !hasWon)
          gameOverMenu.hidepanel();
    }
}
