using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHDictionary : MonoBehaviour
{
    private Dictionary<int, string> _dictionary;

    private void Start()
    {
        _dictionary = new Dictionary<int, string>();

        _dictionary.Add(0, "Top Pordig");
        _dictionary.Add(2, "Risok Gend");
        _dictionary.Add(5, "Virpos Ciner");
        _dictionary.Add(8, "Prina Winq");

        _dictionary[2] = "Tim Berder";

        string dTemp = "";
        foreach (KeyValuePair<int, string> kvp in _dictionary)
        {
            dTemp += kvp + " ";
            // kvp.key
            // kvp.value
        }
        Debug.Log(dTemp);

        _dictionary.Clear();

        _dictionary[0] = "Gonki";
        _dictionary[1] = "Gonki";
        _dictionary[5] = "Gonki";

        string reDTemp = "";
        foreach (KeyValuePair<int, string> kvp in _dictionary)
        {
            reDTemp += kvp + " ";
            // kvp.key
            // kvp.value
        }
        Debug.Log(reDTemp);

        _dictionary = new Dictionary<int, string>()
        {
            {0, "Очередной ремув" },
            {3, "Жиза" },
            {5, "А чё поделать..." },
            {18, "Это новый список как-бы" }
        };

        string newDTemp = "";
        foreach (KeyValuePair<int, string> kvp in _dictionary)
        {
            newDTemp += kvp + " ";
            // kvp.key
            // kvp.value
        }
        Debug.Log(newDTemp);
        Debug.Log("Размер библиотеки = " + _dictionary.Count);
    }
}
