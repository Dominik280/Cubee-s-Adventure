using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float speed;
    public float jumpForce;
    private float moveInput;
    private Rigidbody2D rb;

    private bool isOnGround;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpsValue;

    public bool isPlayerBlue = true;

    public Sprite redPlayer;
    public Sprite bluePlayer;
    public Sprite skin1_blue;
    public Sprite skin1_red;
    public Sprite skin2_blue;
    public Sprite skin2_red;
    public Sprite skin3_blue;
    public Sprite skin3_red;
    public Sprite skin4_blue;
    public Sprite skin4_red;
    public Sprite skin5_blue;
    public Sprite skin5_red;

    public static bool skin1Equipped = false;
    public static bool skin2Equipped = false;
    public static bool skin3Equipped = false;
    public static bool skin4Equipped = false;
    public static bool skin5Equipped = false;

    
    public void Skin() 
    {
        if (skin1Equipped == true && isPlayerBlue == true) { this.gameObject.GetComponent<SpriteRenderer>().sprite = skin1_blue; }
        if (skin2Equipped == true && isPlayerBlue == true) { this.gameObject.GetComponent<SpriteRenderer>().sprite = skin2_blue; }
        if (skin3Equipped == true && isPlayerBlue == true) { this.gameObject.GetComponent<SpriteRenderer>().sprite = skin3_blue; }
        if (skin4Equipped == true && isPlayerBlue == true) { this.gameObject.GetComponent<SpriteRenderer>().sprite = skin4_blue; }
        if (skin5Equipped == true && isPlayerBlue == true) { this.gameObject.GetComponent<SpriteRenderer>().sprite = skin5_blue; }
    }

    private void Start()
    {
        extraJumps = extraJumpsValue - 1;
        rb = GetComponent<Rigidbody2D>();
        Physics2D.IgnoreLayerCollision(9, 11, true);
        Physics2D.IgnoreLayerCollision(9, 12, false);
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0) //skok s extra skokem
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && isOnGround == true) // normální skok
        {
            rb.velocity = Vector2.up * jumpForce;
        }
        if (isOnGround == true)   // pokud se dotknu země, obnoví se mi extra skok
        {
            extraJumps = extraJumpsValue;
        }

        Skin();
    }

    void FixedUpdate()
    {
        moveInput = (Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed);
        rb.velocity = new Vector2(moveInput, rb.velocity.y);

        isOnGround = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        
        //pokud budu mimo kameru -> konec
        if(rb.position.x < -43) 
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    
    //změna barvy
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Switch ball") && isPlayerBlue == true) 
        {
            Physics2D.IgnoreLayerCollision(9, 12, true);
            Physics2D.IgnoreLayerCollision(9, 11, false);
            isPlayerBlue = false;
            if (skin1Equipped == true) { this.gameObject.GetComponent<SpriteRenderer>().sprite = skin1_red; }
            else if (skin2Equipped == true) { this.gameObject.GetComponent<SpriteRenderer>().sprite = skin2_red; }
            else if (skin3Equipped == true) { this.gameObject.GetComponent<SpriteRenderer>().sprite = skin3_red; }
            else if (skin4Equipped == true) { this.gameObject.GetComponent<SpriteRenderer>().sprite = skin4_red; }
            else if (skin5Equipped == true) { this.gameObject.GetComponent<SpriteRenderer>().sprite = skin5_red; }
            else { this.gameObject.GetComponent<SpriteRenderer>().sprite = redPlayer; }
        }
        else if (collision.CompareTag("Switch ball") && isPlayerBlue == false)
        {
            Physics2D.IgnoreLayerCollision(9, 12, false);
            Physics2D.IgnoreLayerCollision(9, 11, true);
            isPlayerBlue = true;
            if (skin1Equipped == true) { this.gameObject.GetComponent<SpriteRenderer>().sprite = skin1_blue; }
            else if (skin2Equipped == true) { this.gameObject.GetComponent<SpriteRenderer>().sprite = skin2_blue; }
            else if (skin3Equipped == true) { this.gameObject.GetComponent<SpriteRenderer>().sprite = skin3_blue; }
            else if (skin4Equipped == true) { this.gameObject.GetComponent<SpriteRenderer>().sprite = skin4_blue; }
            else if (skin5Equipped == true) { this.gameObject.GetComponent<SpriteRenderer>().sprite = skin5_blue; }
            else { this.gameObject.GetComponent<SpriteRenderer>().sprite = bluePlayer; }
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.collider.CompareTag("Blue wall") || coll.collider.CompareTag("Red wall") || coll.collider.CompareTag("Spike")) 
        {
            FindObjectOfType<GameManager>().EndGame();
        }    
    }


}
