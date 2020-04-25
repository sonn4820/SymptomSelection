using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckScore : MonoBehaviour
{
    
    public Vector3 rightpos;
    public bool correct;
    RectTransform SS;
    

    // Start is called before the first frame update
    void Start()
    {
        SS = GetComponent<RectTransform>();
        correct = false;
    }

    // Update is called once per frame
    void Update()
    {
       if(SS.localPosition == rightpos)
        {
            correct = true;
            
        }

       

        Debug.Log(correct);
    }
    
}
