using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRb;
    private float inputRaw;
    GroundCheck groundCheck;
    Animator playerAnimator;
    SpriteRenderer playerSpRenderer;

    [SerializeField] float moveSpeed = 100f;
    [SerializeField] float jumpPower = 100f;
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerSpRenderer = GetComponent<SpriteRenderer>();
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        inputRaw = Input.GetAxisRaw("Horizontal");
        moveLeftRight();
        moveJump();
        flipSprite();

    }



    void moveLeftRight()
    {
        playerRb.velocity = new Vector2(inputRaw * moveSpeed * Time.deltaTime, playerRb.velocity.y);


        playerAnimator.SetBool("Running", true);
    }

    void flipSprite()
    {
        if (playerRb.velocity.x > 0)
        {
            playerSpRenderer.flipX = false;
        }

        else if (playerRb.velocity.x < 0)
        {
            playerSpRenderer.flipX = true;
        }
        else
        {
            playerAnimator.SetBool("Running", false);
        }



    }

    void moveJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && GroundCheck.isGrounded == true)
        {
            playerRb.velocity = new Vector2(playerRb.velocity.x, Time.deltaTime * jumpPower);
        }
    }

}

