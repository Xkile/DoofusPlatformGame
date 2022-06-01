using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlatformSpawn : MonoBehaviour
{
    #region Internal Members
    [SerializeField]
    GameObject platformPrefab;
    [SerializeField]
    Vector3[] availablePositions;
    [SerializeField]
    Vector3 currentPos;
    [SerializeField]
    float spawnTimer;
    [SerializeField]
    int prevSpawnDir;
    [SerializeField]
    int newSpawnDir;
    GameObject newPlatform;
   #endregion

    #region Public Members
    public GameObject currentPlatform;
    #endregion
    
    #region Monobehavour
    // Start is called before the first frame update
    void Start()
    {
        currentPos = currentPlatform.transform.position;

        InvokeRepeating("SpawnPlatform",3f,5.5f - GameManager.instance.pulpitSpawnTime);
        availablePositions = new Vector3 [4];
    }

    // Update is called once per frame
    void Update()
    {
        availablePositions[0]= new Vector3 (currentPos.x+18, currentPos.y, currentPos.z);
        availablePositions[1]= new Vector3 (currentPos.x-18, currentPos.y, currentPos.z);
        availablePositions[2]= new Vector3 (currentPos.x, currentPos.y, currentPos.z+18);
        availablePositions[3]= new Vector3 (currentPos.x, currentPos.y, currentPos.z-18);
    }
    #endregion

    #region Internal Methods
    void SpawnPlatform(){
            
            while(newSpawnDir == prevSpawnDir){
                newSpawnDir = Random.Range(0,4);
            }
           newPlatform = Instantiate(platformPrefab,availablePositions[newSpawnDir], Quaternion.identity);
           newPlatform.GetComponent<Rigidbody>().isKinematic = true;
           newPlatform.transform.GetChild(0).transform.gameObject.SetActive(true);
            currentPos = newPlatform.transform.position;
            prevSpawnDir = newSpawnDir;
    }
    #endregion
}
