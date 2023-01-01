using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHVector : MonoBehaviour
{
    // ������������� �������� x, y, z
    private Vector3 _position = new Vector3(0.0f, 3.0f, 4.0f);
    private Vector3 _position1 = new Vector3(1.0f, 2.0f, 7.0f);

    private void Start()
    {
        // ������� x, y, z 
        Debug.Log(_position);

        Debug.Log(_position.x);
        Debug.Log(_position.y);
        Debug.Log(_position.z);

        // ���������� ���������� Vector3 �� 0,0,0, magnitude - �����
        Debug.Log(_position.magnitude);

        // _position.Normalize();
        // ������������� �������� magnitude ������ 1 
        Debug.Log(_position.normalized);

        Debug.Log(Vector3.zero); // 0,0,0

        Debug.Log(Vector3.one); // 1,1,1

        Debug.Log(Vector3.left); // -1,0,0

        Debug.Log(Vector3.up); // 0,1,0

        Debug.Log(Vector3.forward); // 0,0,1

        // ��������� ������������ ���� ����������� ��������
        Debug.Log(Vector3.Cross(_position,_position1));
        // ��������� ������������ ���� ����������� ��������
        Debug.Log(Vector3.Dot(_position,_position1));
    }
}
