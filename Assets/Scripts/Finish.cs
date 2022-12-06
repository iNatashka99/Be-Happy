using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public bool isFinished;
    public GameObject raduga;
    void Start()
    {
        isFinished = false;
        raduga.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isFinished)
        {
            raduga.SetActive(true);
            PlayerPrefs.SetString("finish", "yes");
        }
    }
}
