using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public GameObject directionLight;
    public Transform camTransform;
    private Transform lightTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);

        //directionLight = GameObject.Find("Directional Light");

        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);

        //class are reference type (pass by reference)
        //Character heroPawn = new Character("Ashen One");
        //heroPawn.PrintStatsInfo();

        //struct are value types (passed by value)
        Weapon DragonslayerGreataxe = new Weapon("Dragonslayer Greataxe", 1000);
        DragonslayerGreataxe.PrintWeaponStats();

        AshenOne ashenOne = new AshenOne("Galliume", DragonslayerGreataxe);
        ashenOne.PrintStatsInfo();

        Generic<int> highScores = new Generic<int>();
        highScores.GenericMethod<string>("generic");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
