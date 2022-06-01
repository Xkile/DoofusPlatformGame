using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public int movespeed;
    public static MovementController instance;
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        movespeed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movespeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, movespeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
