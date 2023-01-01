using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHWhile : MonoBehaviour
{
    private void Start()
    {
        int i = 3;
        while (i > 0)
        {
            i--;
            Debug.Log(i);
        }
    }
}
