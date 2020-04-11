using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManagement : MonoBehaviour
{
    public Text QTestObj;
    public Text Systext;
    public Text Score;

    List<string> questions = new List<string>() {"Rash1", "Rash2", "Rash3", "Rash4" };
    List<string> correctSelection = new List<string>() {"choice1", "choice2", "choice3", "choice4" };

    public static string currentSelection;
    public static int textPointer;

    public static string playerClicked = "N"; // another way for bool
    public static string loadQuestion = "Y";

    public static int totalScore = 0;

    public static int answeredQuestion = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(loadQuestion == "Y")
        {
            textPointer = Random.Range(1, 4);
            QTestObj.text = questions[textPointer];
        }

        if (answeredQuestion >= 4)
        {
            SceneManager.LoadScene("End");
        }
        Debug.Log("Question" + answeredQuestion);

        Check();
    }
    
    void Check()
    {
        if (playerClicked == "Y")
        {
            if (currentSelection == correctSelection[textPointer])
            {
                Systext.text = "Correct";
                playerClicked = "N";
                totalScore += 1;
                Score.text = "Score: " + totalScore;
            }
            else
            {
                Systext.text = "Incorrect";
            }
        }
    }
    void LateUpdate()
    {
        loadQuestion = "N";

    }
    public void Load()
    {
        loadQuestion = "Y";
        Systext.text = "";
        answeredQuestion += 1;
    }
}
