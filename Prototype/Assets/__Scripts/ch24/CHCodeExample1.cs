using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHCodeExample1 : MonoBehaviour
{
    private void Awake()
    {
        Say("��� ����!");
    }

    private void Say( string say)
    {
        Debug.Log(say);
    }
}
