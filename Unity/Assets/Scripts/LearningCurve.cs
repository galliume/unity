using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private int currentAge = 30;
    public int addedAge = 30;
    public string fistName = "Galliume";

    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();

        Debug.Log($"A string can have variables like {firstName} inserted directly");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
    }
}
