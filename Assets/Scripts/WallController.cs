using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public SpriteRenderer mySpriteRenderer;
    public Sprite invis;
    
    private void Awake ()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        mySpriteRenderer.sprite = invis;
    }
}