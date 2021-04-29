using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

public class AshenOne : Character
{
    public Weapon weapon;

    public AshenOne(string name, Weapon weapon) : base(name)
    {
        this.weapon = weapon;
    }

    public override void PrintStatsInfo()
    {
        Debug.LogFormat("Ashen One: {0} - {1} EXP", this.name, this.exp);
    }
}