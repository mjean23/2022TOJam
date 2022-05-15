using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireProjectileController : MonoBehaviour
{
    public string direction = "left";
    public int FIREBALL_SPEED = 200;
    // Start is called before the first frame update
    void Start()
    {
        this.setStartDirection(this.direction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void setStartDirection(string direction) {
        switch (direction) {
            case "left":
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * FIREBALL_SPEED);
                break;
            case "right":
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * FIREBALL_SPEED);
                break;
            case "up":
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * FIREBALL_SPEED);
                break;
            case "down":
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.down * FIREBALL_SPEED);
                break;
            default:
                break;
        }
    }
    
    public void OnTriggerEnter2D (Collider2D col) {
        if (col.gameObject.name == "Player") {
            SceneManager.LoadScene("GameOver");
        } else if (col.gameObject.CompareTag("Wall")) {
            var fireVelocity = gameObject.GetComponent<Rigidbody2D>().velocity;
            gameObject.GetComponent<Rigidbody2D>().velocity = (fireVelocity * -1);
        } else if (col.gameObject.CompareTag("OoB")) {
            transform.localPosition = new Vector3(0, 0, 0);
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            this.setStartDirection(this.direction);
        }
    }
}
