using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OoBCollisison : MonoBehaviour
{
    public SpriteRenderer mySpriteRenderer;
    public Sprite invis;
    
    private void Awake ()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        mySpriteRenderer.sprite = invis;
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.name == "Player") {
            SceneManager.LoadScene("GameOver");
        }
    }
}
