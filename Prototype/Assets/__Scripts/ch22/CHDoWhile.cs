using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHDoWhile : MonoBehaviour
{
    private void Start()
    {
        int i = 0;
        do
        {
            i++;
            Debug.Log(i);
        }
        while (i < 5);
    }
}
