using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHCodeExample9 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log(Fac(5));
        Debug.Log(Fac(0));
        Debug.Log(Fac(-5));
    }

    private int Fac(int n)
    {
        if (n < 0) return 0;

        if (n == 0) return 1;

        int result = n * Fac(n - 1);
        return result;
    }
}
