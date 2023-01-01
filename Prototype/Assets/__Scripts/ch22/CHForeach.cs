using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHForeach : MonoBehaviour
{
    private void Start()
    {
        string str = "GameDev";
        string strTemp = "";
        foreach (char ch in str)
        {
            strTemp += ch + " ";
        }
        Debug.Log(strTemp);
    }
}
