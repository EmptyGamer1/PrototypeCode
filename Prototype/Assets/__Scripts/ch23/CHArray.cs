using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHArray : MonoBehaviour
{
    private string[] _array;

    private void Start()
    {
        _array = new string[7];

        _array[0] = "Piter Pen";
        _array[3] = "Bob Marpl";
        _array[6] = "Clara Given";

        string aTemp = "";
        foreach (string a in _array)
        {
            if (a == null) continue;
            aTemp += a + " | ";
        }
        Debug.Log(aTemp);

        // Шик, блеск!
        string bTemp = "";
        foreach (string a in _array)
        {
            if (a == null) bTemp += " | ";
            bTemp += a;
        }
        Debug.Log(bTemp);

        string cTemp = "";
        foreach (string a in _array)
        {
            cTemp += " | " + a;
            if (a == null) break;
        }
        Debug.Log(cTemp);
        Debug.Log($"Размер массива =  {_array.Length}");

        // Возвращает индекс элемента массива, иначе вернет -1
        Debug.Log($"Индекс равен = {System.Array.IndexOf(_array, "Bob Marpl")}");

        // Изменяет размер массива
        System.Array.Resize(ref _array, 2);

        string dTemp = "";
        foreach (string a in _array)
        {
            if (a == null) dTemp += " | ";
            dTemp += a;
        }
        Debug.Log(dTemp);
        Debug.Log($"Размер массива =  {_array.Length}");
    }
}
