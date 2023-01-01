using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHCodeExample3 : MonoBehaviour
{
    private void Awake()
    {
        int sum = Add(3, 6);
        Debug.Log(sum);
    }

    private int Add(int munA, int numB)
    {
        return munA + numB;
    }
}
