// this script is attached to camera
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    

    void Update()
    {
        Vector3 cameraPos = transform.position;

        if (player.position.y < -3.22)      //player fell in water
            cameraPos.y = player.position.y + 4.5f;

        else if (player.position.y > 3.5)     //player is in air at height
            cameraPos.y = player.position.y - 1.5f;
        
        cameraPos.x = player.position.x;
        transform.position = cameraPos;
    }
}
