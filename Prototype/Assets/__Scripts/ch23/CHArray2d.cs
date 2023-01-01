using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHArray2d : MonoBehaviour
{
    private string[,] _array;

    private void Start()
    {
        _array = new string[4, 4]
        {
            {"Ну ", "че",", ","как " },
            {"дела", "? ","Как ","поживаешь" },
            {"? ", "Что ","делаешь" ,"? "  },
            {"Чем ", "сейчас ","занят" ,"? "  }
        };

        string aTemp = "";

        foreach (string s in _array)
        {
            aTemp += s;
        }
        Debug.Log(aTemp);

        string bTemp = " ";

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (_array[i, j] != null)
                    bTemp += _array[i, j];
            }
            bTemp += "\n";
        }
        Debug.Log(bTemp);
    }
}
