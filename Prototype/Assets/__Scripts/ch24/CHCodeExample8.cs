using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHCodeExample8 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log(Add(1));
        Debug.Log(Add(1, 2));
        Debug.Log(Add(1, 2, 3));
        Debug.Log(Add(1, 2, 3, 4));
        Debug.Log(Add(1, 2, 3, 4, 5));
    }

    private int Add(params int[] ints)
    {
        int sum = 0;
        foreach (int i in ints)
        {
            sum += i;
        }
        return sum;
    }
}
