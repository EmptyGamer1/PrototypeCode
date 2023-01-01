using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHCodeExample6 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log(Add(1.0f, 2.5f));
        Debug.Log(Add(new Vector3(1, 0, 0), new Vector3(0, 1, 0)));
        Color colorA = new Color(0.21f, 1, 0, 1);
        Color colorB = new Color(0.25f, 0.33f, 0, 1);
        Debug.Log(Add(colorA, colorB));
    }

    private float Add(float f0, float f1)
    {
        return f0 + f1;
    }

    private Vector3 Add(Vector3 v0, Vector3 v1)
    {
        return v0 + v1;
    }

    private Color Add(Color c0, Color c1)
    {
        float r, g, b, a;
        r = Mathf.Min(c0.r, c1.r, 1.0f);
        g = Mathf.Min(c0.g, c1.g, 1.0f);
        b = Mathf.Min(c0.b, c1.b, 1.0f);
        a = Mathf.Min(c0.a, c1.a, 1.0f);
        return new Color(r, g, b, a);
    }
}
