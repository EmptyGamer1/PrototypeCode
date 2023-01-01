using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    private Transform _camPos;

   // public GameObject DirectionLight;
    private Transform _lightTransform;

    private void Start()
    {
        _camPos = GetComponent<Transform>();
        Debug.Log(_camPos.localPosition);

       // DirectionLight = GameObject.Find("Directional Light");
        //_lightTransform = DirectionLight.GetComponent<Transform>();
        _lightTransform = GameObject.Find("Directional Light").GetComponent<Transform>();
        Debug.Log(_lightTransform.localPosition);
    }
}
