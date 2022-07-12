//this script is attached to player

using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public  Rigidbody2D ball;  //rb is player(ball)
    public Rigidbody2D checkpointRb;
    public static bool hasChecked;
    public static Vector2 checkpointpos;

    private void Start()
    {
        checkpointpos = new Vector2(checkpointRb.position.x, checkpointRb.position.y / 100);
        hasChecked = false;
    }

    public void restartFromCheckpoint()
    {
        Debug.Log("restart from checkpoint is called");
        ball.constraints = RigidbodyConstraints2D.None;
        ball.transform.position = checkpointpos;
        gameManage.isGameOver = false;
        gameManage.hasDrowned = false;
        Time.timeScale = 1;
    }
    
   
    
    void Update()
    {
        if (hasChecked && gameManage.isGameOver && gameManage.livesLeft)        //player died after checkpoint
        {
            Debug.Log("player died after checkpont");
            gameOverMenu.hidepanel();
            ball.constraints = RigidbodyConstraints2D.FreezeAll;
            Invoke(nameof(restartFromCheckpoint), 0.1f);
            
        }

        if(!hasChecked && gameManage.isGameOver && gameManage.livesLeft)        //player died before checkpoint
        {
            Debug.Log("player died before checkpoint");
            gameOverMenu.hidepanel();
            gameManage.replay();
        }
        
    }
}
