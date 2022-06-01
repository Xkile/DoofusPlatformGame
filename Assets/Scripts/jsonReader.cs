using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class jsonReader : MonoBehaviour
    {

    #region Public Members    
    public string jsonURL;
    #endregion

    #region Internal Members
    private jsonDataClass jsonData;
    #endregion

    #region Monobehaviour
    private void Start()
    {
        StartCoroutine(getData());
    }
    #endregion

    #region Private Methods
    IEnumerator getData()
    {
        WWW _www = new WWW(jsonURL);
        yield return _www;
        if(_www.error == null)
        {
            processJsonData(_www.text);
        }
        else
        {
            print("Parsing error");
        }
    }
    private void processJsonData(string _url)
    {
        jsonData = JsonUtility.FromJson<jsonDataClass>(_url);
        print(jsonData.player_data);
        print(jsonData.pulpit_data);
        print(jsonData.player_data.speed);
        GameManager.instance.trueSpeed = jsonData.player_data.speed;
        GameManager.instance.minDestroyTime = jsonData.pulpit_data.min_pulpit_destroy_time;
        GameManager.instance.maxDestroyTime = jsonData.pulpit_data.max_pulpit_destroy_time;
        GameManager.instance.pulpitSpawnTime = jsonData.pulpit_data.pulpit_spawn_time;

    }
    #endregion


}

