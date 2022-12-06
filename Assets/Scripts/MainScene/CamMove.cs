using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public GameObject player;
    public GameObject PanelEnd;
    public GameObject TextWin, TextLose;
    private int tim;
    private void Start()
    {
        PanelEnd.SetActive(false);
        tim = 0;
    }
    void Update()
    {

        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);

        if (PlayerPrefs.GetString("finish") == "yes")
        {
            tim++;
            if (tim > 100)
            {
                PanelEnd.SetActive(true);
                TextLose.SetActive(false);
                TextWin.SetActive(true);
            }
        }
        if (PlayerPrefs.GetString("lose") == "yes")
        {
            tim++;
            if (tim > 100)
            {
                PanelEnd.SetActive(true);
                TextLose.SetActive(true);
                TextWin.SetActive(false);
            }
        }
    }
}
