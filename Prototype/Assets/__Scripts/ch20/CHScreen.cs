using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHScreen : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(Screen.width); // Выводит ширину экрана
        Debug.Log(Screen.height); // Выводит высоту экрана
    }
}
