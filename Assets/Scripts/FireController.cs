using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireController : MonoBehaviour
{
    public string direction;
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
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 100);
                break;
            case "right":
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 100);
                break;
            case "up":
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 100);
                break;
            case "down":
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.down * 100);
                break;
            default:
                break;
        }
    }

    public void OnTriggerEnter2D (Collider2D col) {
        if (col.gameObject.name == "Player") {
            SceneManager.LoadScene("Level1");
        } else if (col.gameObject.CompareTag("Wall")) {
            var fireVelocity = gameObject.GetComponent<Rigidbody2D>().velocity;
            gameObject.GetComponent<Rigidbody2D>().velocity = (fireVelocity * -1);
        }
    }
}
