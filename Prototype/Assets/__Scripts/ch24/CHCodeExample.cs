using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHCodeExample : MonoBehaviour
{
    private int _num = 0;

    private void Update()
    {
        _num++;
        DebugUpdates();
    }

    private void DebugUpdates()
    {
        string numsTemp = "Вызов апдейта: " + _num;
        Debug.Log(numsTemp);
    }
}
