//this script is attached to player

using UnityEngine;
using UnityEngine.EventSystems;

public class movement : MonoBehaviour
{
    public CircleCollider2D circlecollider;    //ball's circle collider
    public Rigidbody2D player;                 //player is ball
    public float verticalForce;
    [SerializeField] private LayerMask groundLayerMask;
    // ReSharper disable once InconsistentNaming
    private const float EXTRAHEIGHT = .2f;
    bool ispressing;
    public float leftForce, rightForce;
    float FALLMULTI = 3f;


    public void hold()
    {
        ispressing = true;
    }
    public void release()
    {
        ispressing = false;
    }

    public void jump()
    {
        if (isGrounded())
        {
            player.AddForce(new Vector2(0, verticalForce), ForceMode2D.Impulse);
        }
    }

    private bool isGrounded()
    {
        //Debug.Log("inside isGround");
        RaycastHit2D rayCastHit = Physics2D.Raycast(circlecollider.bounds.center, Vector2.down,
            circlecollider.bounds.extents.y + EXTRAHEIGHT, groundLayerMask);
        return rayCastHit.collider != null;

    }

    public void moveLeft()
    {
        if (player.velocity.x > -9)
            player.AddForce(new Vector2(-leftForce, 0), ForceMode2D.Impulse);
    }

    public void moveRight()
    {
        if (player.velocity.x < 9)
            player.AddForce(new Vector2(rightForce, 0), ForceMode2D.Impulse);

    }

    private void Update()
    {
        if (EventSystem.current.currentSelectedGameObject != null)
        {
            if (EventSystem.current.currentSelectedGameObject.name == "leftButton" && ispressing)
                moveLeft();
            else if (EventSystem.current.currentSelectedGameObject.name == "rightButton" && ispressing)
                moveRight();
        }

        if (player.velocity.y < 0)      //adds velocity to ball when its falling
            player.velocity += Vector2.up * (Physics2D.gravity.y * (FALLMULTI - 1) * Time.deltaTime);

    }
}
