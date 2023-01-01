using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHQuaternion : MonoBehaviour
{
    private Quaternion _lookUp45Deg = Quaternion.Euler(-45f, 0, 0);

    private void Start()
    {
        Debug.Log(_lookUp45Deg);
    }
}
