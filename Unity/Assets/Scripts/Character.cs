using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/**
 * dynamic param -> type dynamique résolue à l'execution, pas de check type
 * async / await pour asynchrone
 * System.Threading.Thread pour du multi thread
 * 
 * @todo 
 * 
 * Recursion and reflection
 * LINQ expressions
 */

public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public void PrintWeaponStats()
    {
        Debug.LogFormat("Weapon: {0} - {1} DMB", name, damage);
    }
}

public class Character
{
    public string name;
    public int exp = 0;

    public Character(string name)
    {
        this.name = name;
    }

    public virtual void PrintStatsInfo()
    {
        Debug.LogFormat("heroPawn: {0} - {1} EXP", this.name, this.exp);
    }

    private void Reset()
    {
        this.name = "Not assigned";
        this.exp = 0;
    }
}

public static class ToExtend
{

    public static void testExtension(this string str)
    {
        Debug.Log("option diabolique d'extension de classe");
    }
}

public class AshenOne : Character
{
    public Weapon weapon;

    public AshenOne(string name, Weapon weapon) : base(name)
    {
        this.weapon = weapon;
    }

    public override void PrintStatsInfo()
    {
        debug("Stats info \r\n");
        Debug.LogFormat("Ashen One: {0} - {1} EXP", this.name, this.exp);        
    }

    public void test(in int param) //or out param
    {
        Stack<string> name = new Stack<string>(); //LIFO
        name.Pop();//next item on the stack and removes it
        name.Peek();//next item but keep it in the stack

        Queue<string> nameQueue = new Queue<string>();//FIFO
        //nameQueue.Enqueue();
        //nameQueue.Dequeue();...

        HashSet<string> nameHash = new HashSet<string>();//no duplicate value, not ordered, fast
    }

    public delegate void DebugDelegate(string text);//use for callback
    public DebugDelegate debug = Print;
    public static void Print(string text)
    {
        Debug.Log(text);
    }
    public event EventDelegate eventInstance;//observer / observed += or -= to suscribe to an event
}

public class Generic<T> //where T: class <- filtre le type de T par type
{
    public void GenericMethod<T>(T genericParameter)
    {

    }
}