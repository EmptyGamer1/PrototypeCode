using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private Character _hero;
    private Paladin _knight;
    private Weapon _huntingBow;
    private Weapon _Sword;

    private void Start()
    {
        _hero = new Character("Animeshnik");
        Character HeroDup = _hero;
        _hero.Name = "Winner";

        _huntingBow = new Weapon("Bow", 5);
        Weapon HuntingBowDup = _huntingBow;
        _huntingBow.Name = "LowBow";

        HeroDup.PrintStatsInfo();
        HuntingBowDup.PrintWeaponStats();

        _knight = new Paladin("Knight", _Sword);
        _knight.PrintStatsInfo();
        _knight.Weapon.PrintWeaponStats();
    }
}
