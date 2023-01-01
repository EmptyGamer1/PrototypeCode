using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHCodeExample7 : MonoBehaviour
{
    private void Awake()
    {
        SetX(this.gameObject, 25);
        Debug.Log(this.gameObject.transform.position.x);
        SetX(this.gameObject);
        Debug.Log(this.gameObject.transform.position.x);
    }

    private void SetX(GameObject go, float eX = 0.0f) // Необязательный параметр
    {
        Vector3 tempPos = go.transform.position;
        tempPos.x = eX;
        go.transform.position = tempPos;
    }
}
