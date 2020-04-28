using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SMPlay1 : MonoBehaviour
{

    public enum GameState { K1State, K2State, K3State, K4State, K5State, ScoreState };
    public GameState currentGameState;

    public GameObject K1;
    public GameObject K2;
    public GameObject K3;
    public GameObject K4;
    public GameObject K5;
    public GameObject Score;

    public Text Text1;
    public Text Text2;
    public Text Text3;
    public Text Text4;
    public Text TextFinal;
    public Text Checkcheck;

    int S;
    public AudioClip CorrectSound, IncorrectSound;
    private AudioSource audioSource;


    // Use this for initialization
    void Start()
    {
        currentGameState = GameState.K1State;
        ShowScreen(K1);
        S = 0;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        FinalScore();
        Debug.Log(S);
    }

    void ShowScreen(GameObject gameObjectToShow)
    {

        K1.SetActive(false);
        K2.SetActive(false);
        K3.SetActive(false);
        K4.SetActive(false);
        K5.SetActive(false);
        Score.SetActive(false);
        gameObjectToShow.SetActive(true);
    }


    public void Knowledge1()
    {
        currentGameState = GameState.K1State;
        ShowScreen(K1);
    }
    public void Knowledge2()
    {
        currentGameState = GameState.K2State;
        ShowScreen(K2);
    }
    public void Knowledge3()
    {
        currentGameState = GameState.K3State;
        ShowScreen(K3);
    }
    public void Knowledge4()
    {
        currentGameState = GameState.K4State;
        ShowScreen(K4);
    }
    public void Knowledge5()
    {
        currentGameState = GameState.K5State;
        ShowScreen(K5);
    }
    public void Play()
    {
        SceneManager.LoadScene("Play1");
    }
    public void CheckScore()
    {
        currentGameState = GameState.ScoreState;
        ShowScreen(Score);
    }
    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Q1IC()
    {
        Text1.text = "Incorrect";
        S = S - 25;
        audioSource.PlayOneShot(IncorrectSound);
    }
    public void Q1C()
    {
        Text1.text = "Correct";
        S = S + 25;
        audioSource.PlayOneShot(CorrectSound);
    }
    public void Q2IC()
    {
        Text2.text = "Incorrect";
        S = S - 25;
        audioSource.PlayOneShot(IncorrectSound);
    }
    public void Q2C()
    {
        Text2.text = "Correct";
        S = S + 25;
        audioSource.PlayOneShot(CorrectSound);
    }
    public void Q3IC()
    {
        Text3.text = "Incorrect";
        S = S - 25;
        audioSource.PlayOneShot(IncorrectSound);
    }
    public void Q3C()
    {
        Text3.text = "Correct";
        S = S + 25;
        audioSource.PlayOneShot(CorrectSound);
    }
    public void Q4IC()
    {
        Text4.text = "Incorrect";
        S = S - 25;
        audioSource.PlayOneShot(IncorrectSound);
    }
    public void Q4C()
    {
        Text4.text = "Correct";
        S = S + 25;
        audioSource.PlayOneShot(CorrectSound);
    }
    public void FinalScore()
    {
        TextFinal.text = "Your Score is " + S;
        if (S <= 0)
        {
            Checkcheck.text = "You don't study, right?";
        }
        else if (S == 25)
        {
            Checkcheck.text = "Your mom feels bad about you";
        }
        else if (S == 50)
        {
            Checkcheck.text = "Come on, you're more than that";
        }
        else if (S == 75)
        {
            Checkcheck.text = "Hmmm, that's pretty good";
        }
        else if (S == 100)
        {
            Checkcheck.text = "Genius. I'm proud of you!";
        }

    }
}