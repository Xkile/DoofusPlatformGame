using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region Public Members
    public GameObject platform;
    public GameObject tempPlatform;
    public int trueSpeed;
    public float minDestroyTime;
    public float maxDestroyTime;
    public float pulpitSpawnTime;
    public static GameManager instance;
    public bool startGame = false;
    public GameObject timer;
    public GameObject platformSpawn;
    public GameObject scoreText;
    public GameObject instructions;
    #endregion
    
    #region Internal Members
    [SerializeField]
    GameObject player;
    #endregion

    #region Monobehaviour
    private void Awake()
    {
        instance = this;
    }
    #endregion

    #region Public Methods
    public void StartGame(){
       //platform.transform.DORotate(new Vector3 (0,0,0),3f);
       platform.GetComponent<Rigidbody>().useGravity = true;
        StartCoroutine(PlayerSpawn());     
    }
    #endregion

    #region Internal Methods
    IEnumerator PlayerSpawn(){
        yield return new WaitForSeconds(2.7f);
        player.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        platform.GetComponent<Rigidbody>().isKinematic = true;
        Destroy(tempPlatform);
       //  player.GetComponent<MeshCollider>().material = null;
        Camera.main.transform.DOMove(new Vector3(0,9.31f,-21.27f),3f);
        Camera.main.transform.DORotate(new Vector3(32.24f,0,0),3f);
        yield return new WaitForSeconds (2f);
        instructions.SetActive(true);
        yield return new WaitForSeconds (4f);
        instructions.SetActive(false);
        startGame = true;
        timer.SetActive(true);
        platformSpawn.SetActive(true);
        Camera.main.GetComponent<CameraFollow>().enabled = true;
        scoreText.SetActive(true);
    }
    #endregion
}
