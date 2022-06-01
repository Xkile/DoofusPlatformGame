using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    #region Public Members
    public Text timer;
    public float seconds = 5;
    public float miliseconds = 0;
    #endregion

    #region Monobehaviour
    void Update(){
    if(GameManager.instance.startGame){
        if(miliseconds <= 0){
            float destroyTime = Random.Range(GameManager.instance.minDestroyTime,GameManager.instance.maxDestroyTime);
            print(destroyTime);
        if(seconds <= (5f - destroyTime )){
            //seconds = 59;
            Destroy(this.gameObject);
            return;
        }
        else if(seconds >= 0){
            seconds--;
        }
        miliseconds = 100;
        }
    miliseconds -= Time.deltaTime * 100;
    timer.text = string.Format("{0}:{1}", seconds, (int)miliseconds);
    }
    }
    #endregion
    }
    
