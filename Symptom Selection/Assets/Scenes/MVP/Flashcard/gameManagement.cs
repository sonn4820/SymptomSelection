using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManagement : MonoBehaviour
{
    public Text QTestObj;
    public Text Systext;
    List<string> questions = new List<string>() { "Rash1", "Rash2", "Rash3", "Rash4" };
    List<string> correctSelection = new List<string>() { "choice1", "choice2", "choice3", "choice4" };
    public static string currentSelection;
    public static int textPointer;
    public static string playerClicked = "N";
    public static string loadQuestion = "Y";

    // Start is called before the first frame update
    void Start()
    {
        textPointer = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        QTestObj.text = questions[textPointer];

        if(playerClicked == "Y")
        { 
            if(currentSelection == correctSelection[textPointer])
            {
                Systext.text = "Correct";
                playerClicked = "N";
            }
            else
            {
                Systext.text = "Incorrect";
            }
        }
    }
}
