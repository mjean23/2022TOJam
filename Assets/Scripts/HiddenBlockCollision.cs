using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenBlockCollision : MonoBehaviour
{  
    public SpriteRenderer mySpriteRenderer;
    public Sprite invis;
    public Sprite solid;
    public BoxCollider2D box;
    //public BoxCollider2D boxtrig;
    public EdgeCollider2D edge;
    public bool isHit = false;
    public RaycastHit2D hit;
    Ray ray = new Ray();
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
        // Cast a ray straight down.
        //isHit = Physics2D.Raycast(transform.position, -Vector2.up, 0.3f);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, 0.3f);

        // If it hits something...
        if (hit.collider != null) {
            
            isHit = Physics2D.Raycast(transform.position, -Vector2.up, 0.3f);
            //isHit = true;
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
