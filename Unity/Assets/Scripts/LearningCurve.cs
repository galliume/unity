using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //class are reference type (pass by reference)
        //Character heroPawn = new Character("Ashen One");
        //heroPawn.PrintStatsInfo();

        //struct are value types (passed by value)
        Weapon DragonslayerGreataxe = new Weapon("Dragonslayer Greataxe", 1000);
        DragonslayerGreataxe.PrintWeaponStats();

        AshenOne ashenOne = new AshenOne("Galliume", DragonslayerGreataxe);
        ashenOne.PrintStatsInfo();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
