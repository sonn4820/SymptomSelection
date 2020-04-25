using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SMPlay2 : MonoBehaviour
{

    public enum GameState { IntroState, K1State, K2State, K3State, K4State, K5State };
    public GameState currentGameState;

    public GameObject Intro;
    public GameObject K1;
    public GameObject K2;
    public GameObject K3;
    public GameObject K4;
    public GameObject K5;

    public Text Checkcheck;
    public Text FinalScore;

    public List<CheckScore> checkScores;
    public int Score;

    // Use this for initialization
    void Start()
    {
        currentGameState = GameState.IntroState;
        ShowScreen(Intro);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void ShowScreen(GameObject gameObjectToShow)
    {
        Intro.SetActive(false);
        K1.SetActive(false);
        K2.SetActive(false);
        K3.SetActive(false);
        K4.SetActive(false);
        K5.SetActive(false);

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
        GameOver();
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void GameOver()
    {
        for (int i = 0; i < checkScores.Count; i++)
        {
            if(checkScores[i].correct == true)
            {
                Score += 25;
            }
        }
        FinalScore.text = "Score: " + Score;
        if (Score <= 0)
        {
            Checkcheck.text = "You don't study, right?";
        }
        else if (Score == 25)
        {
            Checkcheck.text = "Your mom feels bad about you";
        }
        else if (Score == 50)
        {
            Checkcheck.text = "Come on, you're more than that";
        }
        else if (Score == 75)
        {
            Checkcheck.text = "Hmmm, that's pretty good";
        }
        else if (Score == 100)
        {
            Checkcheck.text = "Genius. I'm proud of you!";
        }
    }
 
}