using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikesController : MonoBehaviour
{
    public string direction;
    
    public SpriteRenderer mySpriteRenderer;
    public Sprite invis;
    public Sprite solid;
    
    private void Awake () {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        mySpriteRenderer.sprite = invis;
    }
    
    void Start()
    {
        switch (this.direction) {
            case "up":
                gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
                break;
            case "down":
                gameObject.transform.eulerAngles = new Vector3(0, 0, 180);
                break;
            case "left":
                gameObject.transform.eulerAngles = new Vector3(0, 0, 90);
                break;
            case "right":
                gameObject.transform.eulerAngles = new Vector3(0, 0, 270);
                break;
            default: // default to facing up
                gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.name == "Player") {
            SceneManager.LoadScene("GameOver");
        }
    }
}
