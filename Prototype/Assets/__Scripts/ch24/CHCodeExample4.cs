using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHCodeExample4 : MonoBehaviour
{
    [SerializeField] private List<GameObject> exObjects;

    private void Awake()
    {
        MoveToOrigin("Anna");
    }

    private void MoveToOrigin(string name)
    {
        foreach (GameObject gobj in exObjects)
        {
            Debug.Log(gobj.name);
            if (gobj.name == name)
            {
                gobj.transform.position = Vector3.zero;
                gobj.GetComponent<Renderer>().material.color = Color.cyan;
                return;
            }
        }
    }
}
