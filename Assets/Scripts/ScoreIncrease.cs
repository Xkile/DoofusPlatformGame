using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreIncrease : MonoBehaviour
{
    #region Public Members
    public Text ScoreText;
    public int score=0;
    #endregion
    
    #region Internal Methods
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "ScoreTrigger"){
            print("increasing score");
        ScoreText.text = "Score: "+ score++;
        other.gameObject.SetActive(false);
        }else{
            SceneManager.LoadScene(1);
        }
    }

    public void Quit(){
        #if !UNITY_EDITOR
        Application.Quit();
        #else
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
    #endregion
}
