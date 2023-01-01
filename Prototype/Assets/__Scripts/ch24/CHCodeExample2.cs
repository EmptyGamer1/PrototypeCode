using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHCodeExample2 : MonoBehaviour
{
    private void Awake()
    {
        PrintGameObjectName(this.gameObject);
        SetColor(Color.red, this.gameObject);
    }

    private void PrintGameObjectName(GameObject gobj) => Debug.Log(gobj.name);
    private void SetColor(Color color, GameObject gobj)
    {
        Renderer renderer = gobj.GetComponent<Renderer>();
        renderer.material.color = color;
    }
}
