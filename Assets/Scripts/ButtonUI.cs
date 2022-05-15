using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    public void PlayAgainButton(){
            SceneManager.LoadScene("Level1");
    }
    public void ExitButton(){
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
