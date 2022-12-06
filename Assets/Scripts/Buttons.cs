using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject m_on, m_off;

    private void Start()
    {
        if (gameObject.name == "music")
            if (PlayerPrefs.GetString("music") == "no")
            {
                m_off.SetActive(true);
                m_on.SetActive(false);
            }
            else
            {
                m_off.SetActive(false);
                m_on.SetActive(true);
            }
    }

    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "play":
                Application.LoadLevel("Main");
                break;
            case "replay":
                Application.LoadLevel("Main");
                break;
            case "home":
                Application.LoadLevel("Open_Scene");
                break;
            case "help":
                Application.LoadLevel("help");
                break;
            case "close":
                Application.LoadLevel("Open_Scene");
                break;
            case "music":
                if (PlayerPrefs.GetString("music") != "no")
                {
                    PlayerPrefs.SetString("music", "no");
                    m_off.SetActive(true);
                    m_on.SetActive(false);
                }
                else
                {
                    PlayerPrefs.SetString("music", "yes");
                    m_off.SetActive(false);
                    m_on.SetActive(true);
                }
                break;
        }
        if (PlayerPrefs.GetString("music") != "no")
            GameObject.Find("SoundClick").GetComponent<AudioSource>().Play();

    }
}
