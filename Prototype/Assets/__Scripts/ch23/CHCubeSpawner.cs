using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHCubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefabVar;
    [SerializeField] private List<GameObject> _cubePrefabList; // ������ ��� ������

    private float _scalingFactor = 0.95f; // ����������� ��������� ��������
    private int _numCube = 0;

    private void Start()
    {
        _cubePrefabList = new List<GameObject>();
    }

    private void FixedUpdate()
    {
        _numCube++; // ����������� ���������� �����
        GameObject cuberVar = Instantiate(_cubePrefabVar); // ��������� � ������� ������ ���� GameObject
        cuberVar.name = "Cube " + _numCube; // ���������� ��� � ����
        Color color = new Color(Random.value, Random.value, Random.value); // ������������� ��������� ����
        cuberVar.GetComponent<Renderer>().material.color = color; // ���������� ���� � �������� ���� � ���������� Renderer
        cuberVar.transform.position = Random.insideUnitSphere; // ���������� ��������� ������� ���� �������� �����
        _cubePrefabList.Add(cuberVar); // ��������� � ������
        List<GameObject> removeList = new List<GameObject>();

        foreach(GameObject cube in _cubePrefabList)
        {
            float scale = cube.transform.localScale.x; // ������ �����
            scale *= _scalingFactor;
            cube.transform.localScale = Vector3.one * scale; // ���������� �����

            if(scale <= 0.1f)
            {
                removeList.Add(cube);
            }
        }

        foreach(GameObject cube in removeList)
        {
            _cubePrefabList.Remove(cube); // ������� ��� �� ������ _cubePrefabList
            Destroy(cube); // ������� GameObject ����
        }
        removeList.Clear();
    }
}
