using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paladin : Character
{
    public Weapon Weapon;

    public Paladin(string name, Weapon weapon) : base(name)
    {
        weapon.Name = "Sword";
        Weapon = weapon;
    }



}
