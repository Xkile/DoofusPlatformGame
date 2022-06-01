using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    #region Public Methods
    public void LoadScene(int index){
        SceneManager.LoadScene(index);
    }
    #endregion
}
