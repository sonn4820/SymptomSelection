using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GMBegin : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    void Start()
    {
        panel1.gameObject.SetActive(false);
        panel2.gameObject.SetActive(false);
    }
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");

    }
    public void Play()
    {
        panel2.gameObject.SetActive(true);
    }
    public void Choice1()
    {
       
        SceneManager.LoadScene("Play1");
    }
    public void Choice2()
    {
        
        SceneManager.LoadScene("Play2");
    }
    public void Choice3()
    {
        
        SceneManager.LoadScene("Play3");
    }

    public void Credit()
    {
        panel1.gameObject.SetActive(true);
    }
    public void Back()
    {
        panel1.gameObject.SetActive(false);
    }

}
