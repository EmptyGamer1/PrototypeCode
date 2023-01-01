using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHSwitch : MonoBehaviour
{
    private int _num = 2;

    private void Start()
    {
        switch (_num)
        {
            case (0):
                Debug.Log("0");
                break;
            case (1):
                Debug.Log("1");
                break;
            case (2):
            case (4):
                Debug.Log("4");
                break;
            case (7):
                Debug.Log("7");
                break;
            case (8):
                Debug.Log("8");
                break;
            case (10):
                Debug.Log("10");
                break;
            default:
                Debug.Log("Пусто");
                break;
        }
    }
}
