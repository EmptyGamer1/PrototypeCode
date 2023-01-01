using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Name;
    public int Exp;

    public Character()
    {
        Name = "Naruto";
    }

    public Character(string name)
    {
        Name = name;
    }

    public void PrintStatsInfo()
    {
        Debug.Log($"Hero: {Name}, {Exp} - exp");
    }
}

public struct Weapon
{
    public string Name;
    public int Damage;

    public Weapon(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public void PrintWeaponStats()
    {
        Debug.Log($"Weapon: {Name}, {Damage} - damage");
    }
}
