//this script is attached to coins
using UnityEngine;
using UnityEngine.UI;

public class coinCollect : MonoBehaviour
{
    public static int score = 0;
    public Text inGameScoreText;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")    //if ball collides with coin
        {
            Destroy(gameObject);    //destroy coin
            score += 10;
            
        }

        
    }
    private void Update()
    {
        inGameScoreText.text = score.ToString();
    }
}
