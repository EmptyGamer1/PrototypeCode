using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHMathf : MonoBehaviour
{
    private float y = 3;
    private float x = 1;
    private void Start()
    {
        // ���������� ���� �������� ������������ ��� z
        Debug.Log(Mathf.Atan2(y, x));

        // ��������� ����� ���������� � ��������
        Debug.Log(Mathf.PI);

        // ���������� �� ��� �����
        Debug.Log(Mathf.Min(3, 49.1f, 5));
        // ���������� �� ��� �����
        Debug.Log(Mathf.Max(3, -49.1f, 5));

        // ���������� ����� ��� ���� �� ���������� ������
        Debug.Log(Mathf.Round(-49.1f));
        // ���������� ����� �� ���������� �������� ������
        Debug.Log(Mathf.Ceil(-49.1f));
        // ���������� ���� �� ���������� �������� ������
        Debug.Log(Mathf.Floor(-49.1f));

        // ������ �����
        Debug.Log(Mathf.Abs(-25.2f));

        // ��������� ���� �������� float � �������� ���������
        Debug.Log(Mathf.Approximately(-25.2f, -25.20001f));
    }
}
