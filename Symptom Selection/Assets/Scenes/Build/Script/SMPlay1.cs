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

    public Button b1c;
    public Button b1i1;
    public Button b1i2;
    public Button b1i3;

    public Button b2c;
    public Button b2i1;
    public Button b2i2;
    public Button b2i3;

    public Button b3c;
    public Button b3i1;
    public Button b3i2;
    public Button b3i3;

    public Button b4c;
    public Button b4i1;
    public Button b4i2;
    public Button b4i3;

    public Text HiText;
    public string PN1;
    int S;
    public AudioClip CorrectSound, IncorrectSound;
    private AudioSource audioSource;



    // Use this for initialization
    void Awake()
    {
        PN1 = PlayerPrefs.GetString("PN");
    }
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
        HiText.text = "Hi " + PN1 + ", let's test your skill. Each correct answer will give you 25 points. If you get it wrong, you lose 25 points. Let see how many point can you get.";
        
 
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
    public void CheckScore()
    {
        currentGameState = GameState.ScoreState;
        ShowScreen(Score);
    }
    public void Play()
    {
        SceneManager.LoadScene("Play2");
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }
    
    public void Correct()
    {
        if (currentGameState == GameState.K2State)
        {
            Text1.text = "Correct! Nice Job!";
            S = S + 25;
            audioSource.PlayOneShot(CorrectSound);
            b1c.GetComponent<Image>().color = Color.green;
            Text1.GetComponent<Text>().color = Color.green;
            b1i1.gameObject.SetActive(false);
            b1i2.gameObject.SetActive(false);
            b1i3.gameObject.SetActive(false);
        }
        if (currentGameState == GameState.K3State)
        {
            Text2.text = "Correct! Nice Job!";
            S = S + 25;
            audioSource.PlayOneShot(CorrectSound);
            b2c.GetComponent<Image>().color = Color.green;
            Text2.GetComponent<Text>().color = Color.green;
            b2i1.gameObject.SetActive(false);
            b2i2.gameObject.SetActive(false);
            b2i3.gameObject.SetActive(false);
        }
        if (currentGameState == GameState.K4State)
        {
            Text3.text = "Correct! Nice Job!";
            S = S + 25;
            audioSource.PlayOneShot(CorrectSound);
            b3c.GetComponent<Image>().color = Color.green;
            Text3.GetComponent<Text>().color = Color.green;
            b3i1.gameObject.SetActive(false);
            b3i2.gameObject.SetActive(false);
            b3i3.gameObject.SetActive(false);
        }
        if (currentGameState == GameState.K5State)
        {
            Text4.text = "Correct! Nice Job!";
            S = S + 25;
            audioSource.PlayOneShot(CorrectSound);
            b4c.GetComponent<Image>().color = Color.green;
            Text4.GetComponent<Text>().color = Color.green;
            b4i1.gameObject.SetActive(false);
            b4i2.gameObject.SetActive(false);
            b4i3.gameObject.SetActive(false);
        }

    }
    public void Incorrect1()
    {
        if (currentGameState == GameState.K2State)
        {
            Text1.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b1i1.GetComponent<Image>().color = Color.red;
            Text1.GetComponent<Text>().color = Color.red;
            b1c.gameObject.SetActive(false);
            b1i2.gameObject.SetActive(false);
            b1i3.gameObject.SetActive(false);
        }
        if (currentGameState == GameState.K3State)
        {
            Text2.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b2i1.GetComponent<Image>().color = Color.red;
            Text2.GetComponent<Text>().color = Color.red;
            b2c.gameObject.SetActive(false);
            b2i2.gameObject.SetActive(false);
            b2i3.gameObject.SetActive(false);
        }
        if (currentGameState == GameState.K4State)
        {
            Text3.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b3i1.GetComponent<Image>().color = Color.red;
            Text3.GetComponent<Text>().color = Color.red;
            b3c.gameObject.SetActive(false);
            b3i2.gameObject.SetActive(false);
            b3i3.gameObject.SetActive(false);
        }
        if (currentGameState == GameState.K5State)
        {
            Text4.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b4i1.GetComponent<Image>().color = Color.red;
            Text4.GetComponent<Text>().color = Color.red;
            b4c.gameObject.SetActive(false);
            b4i2.gameObject.SetActive(false);
            b4i3.gameObject.SetActive(false);
        }
    }
    public void Incorrect2()
    {
        if (currentGameState == GameState.K2State)
        {
            Text1.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b1i2.GetComponent<Image>().color = Color.red;
            Text1.GetComponent<Text>().color = Color.red;
            b1c.gameObject.SetActive(false);
            b1i1.gameObject.SetActive(false);
            b1i3.gameObject.SetActive(false);
        }
        if (currentGameState == GameState.K3State)
        {
            Text2.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b2i2.GetComponent<Image>().color = Color.red;
            Text2.GetComponent<Text>().color = Color.red;
            b2c.gameObject.SetActive(false);
            b2i1.gameObject.SetActive(false);
            b2i3.gameObject.SetActive(false);
        }
        if (currentGameState == GameState.K4State)
        {
            Text3.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b3i2.GetComponent<Image>().color = Color.red;
            Text3.GetComponent<Text>().color = Color.red;
            b3c.gameObject.SetActive(false);
            b3i1.gameObject.SetActive(false);
            b3i3.gameObject.SetActive(false);
        }
        if (currentGameState == GameState.K5State)
        {
            Text4.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b4i2.GetComponent<Image>().color = Color.red;
            Text4.GetComponent<Text>().color = Color.red;
            b4c.gameObject.SetActive(false);
            b4i1.gameObject.SetActive(false);
            b4i3.gameObject.SetActive(false);
        }
    }
    public void Incorrect3()
    {
        if (currentGameState == GameState.K2State)
        {
            Text1.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b1i3.GetComponent<Image>().color = Color.red;
            Text1.GetComponent<Text>().color = Color.red;
            b1c.gameObject.SetActive(false);
            b1i2.gameObject.SetActive(false);
            b1i1.gameObject.SetActive(false);
        }
        if (currentGameState == GameState.K3State)
        {
            Text2.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b2i3.GetComponent<Image>().color = Color.red;
            Text2.GetComponent<Text>().color = Color.red;
            b2c.gameObject.SetActive(false);
            b2i2.gameObject.SetActive(false);
            b2i1.gameObject.SetActive(false);
        }
        if (currentGameState == GameState.K4State)
        {
            Text3.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b3i3.GetComponent<Image>().color = Color.red;
            Text3.GetComponent<Text>().color = Color.red;
            b3c.gameObject.SetActive(false);
            b3i2.gameObject.SetActive(false);
            b3i1.gameObject.SetActive(false);
        }
        if (currentGameState == GameState.K5State)
        {
            Text4.text = "Sorry, that is incorrect";
            audioSource.PlayOneShot(IncorrectSound);
            b4i3.GetComponent<Image>().color = Color.red;
            Text4.GetComponent<Text>().color = Color.red;
            b4c.gameObject.SetActive(false);
            b4i2.gameObject.SetActive(false);
            b4i1.gameObject.SetActive(false);
        }
    }

    public void FinalScore()
    {
        TextFinal.text = "Your Score is " + S;
        if (S <= 0)
        {
            Checkcheck.text = "Such a disgrace";
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
            Checkcheck.text = "Hey, that was pretty good";
        }
        else if (S == 100)
        {
            Checkcheck.text = "Genius. I'm proud of you!";
        }

    }
}