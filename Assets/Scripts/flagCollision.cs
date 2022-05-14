using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class flagCollision : MonoBehaviour{

    
    
    public void OnTriggerEnter2D (Collider2D col){
    
        if (col.gameObject.name == "Flag"){
            SceneManager.LoadScene("Level 1");
        }
      
    }
}
