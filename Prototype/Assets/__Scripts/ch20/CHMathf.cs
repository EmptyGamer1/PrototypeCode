using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHMathf : MonoBehaviour
{
    private float y = 3;
    private float x = 1;
    private void Start()
    {
        // Возвращает угол поворота относительно оси z
        Debug.Log(Mathf.Atan2(y, x));

        // Отношение длины окружности к диаметру
        Debug.Log(Mathf.PI);

        // Наименьшее из трёх чисел
        Debug.Log(Mathf.Min(3, 49.1f, 5));
        // Наибольшее из трёх чисел
        Debug.Log(Mathf.Max(3, -49.1f, 5));

        // Округление вверх или вниз до ближайшего целого
        Debug.Log(Mathf.Round(-49.1f));
        // Округление вверх до следующего большего целого
        Debug.Log(Mathf.Ceil(-49.1f));
        // Округление вниз до следующего меньшего целого
        Debug.Log(Mathf.Floor(-49.1f));

        // Модуль числа
        Debug.Log(Mathf.Abs(-25.2f));

        // Сравнение двух значений float с заданной точностью
        Debug.Log(Mathf.Approximately(-25.2f, -25.20001f));
    }
}
