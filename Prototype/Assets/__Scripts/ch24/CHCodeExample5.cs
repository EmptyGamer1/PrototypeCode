using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHCodeExample5 : MonoBehaviour
{
    [SerializeField] private List<GameObject> _gameObjects;

    private void Awake()
    {
        var go = _gameObjects;
        AlignX(go);
    }

    private void AlignX(List<GameObject> go)
    {
        float avgX = 0;

        foreach (GameObject obj in _gameObjects)
        {
            avgX += AvgX(obj);
        }
        avgX /= go.Count;

        Debug.Log(avgX);

        foreach (GameObject obj in _gameObjects)
        {
            SetX(obj, avgX);
        }

        //avgX += AvgX(gobj0);
        //avgX += AvgX(gobj1);
        //avgX += AvgX(gobj2);
        //avgX /= 3.0f;
        //SetX(gobj0, avgX);
        //SetX(gobj1, avgX);
        //SetX(gobj2, avgX);
        //----------------------
        //float avgX = gobj0.transform.position.x;
        //avgX += gobj1.transform.position.x;
        //avgX += gobj2.transform.position.x;
        //avgX /= 3.0f; // Среднее значение общего расстояния
        //Vector3 tempPos;
        //tempPos = gobj0.transform.position;
        //tempPos.x = avgX;
        //gobj0.transform.position = tempPos;

        //tempPos = gobj1.transform.position;
        //tempPos.x = avgX;
        //gobj1.transform.position = tempPos;

        //tempPos = gobj2.transform.position;
        //tempPos.x = avgX;
        //gobj2.transform.position = tempPos;
    }

    private void SetX(GameObject go, float eX)
    {
        Vector3 tempPos = go.transform.position;
        tempPos.x = eX;
        go.transform.position = tempPos;
    }

    private float AvgX(GameObject go)
    {
        float avgX = go.transform.position.x;
        return avgX;
    }
}
