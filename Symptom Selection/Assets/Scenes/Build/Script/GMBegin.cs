using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GMBegin : MonoBehaviour
{
    public GameObject panel;

    void Start()
    {
        panel.gameObject.SetActive(false);
    }
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");

    }
    public void Play()
    {
        SceneManager.LoadScene("Play1");
    }
    public void Credit()
    {
        panel.gameObject.SetActive(true);
    }
    public void Back()
    {
        panel.gameObject.SetActive(false);
    }

}
