using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenBlockCollision : MonoBehaviour
{  
    public SpriteRenderer mySpriteRenderer;
    public Sprite invis;
    public Sprite solid;
    public BoxCollider2D box;
    public EdgeCollider2D edge;
    public bool isHit = false;
    public RaycastHit2D hit;
    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    
    
    private void Awake ()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        mySpriteRenderer.sprite = invis;
    }
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, 0.3f);

        
        if (hit.collider != null) {
            
            isHit = Physics2D.Raycast(transform.position, -Vector2.up, 0.3f);
        } else {
            isHit = false;
        }
    }
    
    public void OnCollisionEnter2D (Collision2D col){
      if (isGrounded == false) {
          box.GetComponent<BoxCollider2D>().enabled = true;
          edge.GetComponent<EdgeCollider2D>().enabled= false;
          mySpriteRenderer.sprite = solid;
      }
    }
}
