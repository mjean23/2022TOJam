using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {
    private static MusicManager musicManInst;
    
    void Start() {
        DontDestroyOnLoad(this);
        
        if (musicManInst == null) {
            musicManInst = this;
        } else {
            Destroy(gameObject);
        }
    }
}
