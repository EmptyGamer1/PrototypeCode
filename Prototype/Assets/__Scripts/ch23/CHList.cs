using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHList : MonoBehaviour
{
    private List<string> _name;

    private void Start()
    {
        _name = new List<string>();
        _name.Add("Ferber");
        _name.Add("Zoe");
        _name.Add("Nikrus");

        string nameTemp = "";

        foreach (string name in _name)
        {
            nameTemp += name + " ";
        }
        Debug.Log(nameTemp);

        _name.Remove("Zoe");

        string reNameTemp = "";

        foreach (string name in _name)
        {
            reNameTemp += name + " ";
        }
        Debug.Log(reNameTemp);

        _name.Clear();

        string clNameTemp = "";

        if (_name.Count > 0)
        {
            foreach (string name in _name)
            {
                clNameTemp += name + " ";
            }
            Debug.Log(clNameTemp);
        }
        else
            Debug.Log("Список чист");
    }
}
