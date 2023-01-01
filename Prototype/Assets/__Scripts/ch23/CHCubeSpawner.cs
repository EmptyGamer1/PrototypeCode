using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHCubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefabVar;
    [SerializeField] private List<GameObject> _cubePrefabList; // Храним все кубики

    private float _scalingFactor = 0.95f; // Коэффициент изменения масштаба
    private int _numCube = 0;

    private void Start()
    {
        _cubePrefabList = new List<GameObject>();
    }

    private void FixedUpdate()
    {
        _numCube++; // Увеличиваем количество кубов
        GameObject cuberVar = Instantiate(_cubePrefabVar); // объявляем и создаем объект типа GameObject
        cuberVar.name = "Cube " + _numCube; // Записываем имя в кубе
        Color color = new Color(Random.value, Random.value, Random.value); // Устанавливаем случайный цвет
        cuberVar.GetComponent<Renderer>().material.color = color; // Записываем цвет в материал куба в компоненте Renderer
        cuberVar.transform.position = Random.insideUnitSphere; // Записываем случайную позицию куба радиусом сферы
        _cubePrefabList.Add(cuberVar); // Добавляем в список
        List<GameObject> removeList = new List<GameObject>();

        foreach(GameObject cube in _cubePrefabList)
        {
            float scale = cube.transform.localScale.x; // Задаем скейл
            scale *= _scalingFactor;
            cube.transform.localScale = Vector3.one * scale; // Записываем скейл

            if(scale <= 0.1f)
            {
                removeList.Add(cube);
            }
        }

        foreach(GameObject cube in removeList)
        {
            _cubePrefabList.Remove(cube); // Удалить куб из списка _cubePrefabList
            Destroy(cube); // Удалить GameObject куба
        }
        removeList.Clear();
    }
}
