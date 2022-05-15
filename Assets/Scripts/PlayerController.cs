using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;
    
    private Rigidbody2D rb;
    
    public bool facingRight = true;
    
    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public LayerMask whatIsGround2;
    
    private bool top = false;
    
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate(){
        
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        if (isGrounded == false) {
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround2);
        }
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput*speed, rb.velocity.y);
        
        if(facingRight == false && moveInput > 0){
            reflect();
        } else if (facingRight == true && moveInput <0){
            reflect();
        }
        
    }
    
    void Update(){
        jump();
        if (Input.GetKeyDown(KeyCode.Escape)){
           // UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
    }
    
    void jump(){
        if(Input.GetKeyDown(KeyCode.W) && isGrounded == true||Input.GetKeyDown(KeyCode.Space) && isGrounded == true){
                rb.velocity = Vector2.up * jumpForce;
        }
    }
    
    void reflect(){
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
    
    void Rotation(){
        if(top == false){
            transform.eulerAngles = new Vector3(0,0,180f);
        } else {
            transform.eulerAngles = Vector3.zero;
        }
        
        facingRight = !facingRight;
        top = !top;
    }
}
