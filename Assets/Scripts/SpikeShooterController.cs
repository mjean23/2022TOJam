using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeShooterController : MonoBehaviour
{
    public bool shootSpikes;
    public string shootDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ShootSpikes() {
        switch (this.shootDirection) {
            case "up":
                transform.parent.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 200);
                break;
            case "down":
                transform.parent.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.down * 200);
                break;
            case "left":
                transform.parent.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 200);
                break;
            case "right":
                transform.parent.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 200);
                break;
            default:
                Debug.Log("Invalid shooting direction specified.");
                break;
        }
    }

    public void OnTriggerEnter2D(Collider2D col) {

        if (col.gameObject.name == "Player" && this.shootSpikes)
        {
            this.ShootSpikes();
        }

    }
}
