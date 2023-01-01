using System.Collections;
using UnityEngine;

public class CHColor : MonoBehaviour
{
    private Color _darkGreen = new Color(0f, 0.25f, 0f); // Если альфа не указана, то по дефолту она равна 1 - полностью не прозрачна
    private Color darkRedTranslucent = new Color(0.25f, 0f, 0f, 0.5f);

    private void Start()
    {
        Debug.Log(Color.yellow.r); // Красный компонент желтого
        Debug.Log(Color.yellow.g); // Зеленый компонент желтого
        Debug.Log(Color.yellow.b); // Синий компонент желтого
        Debug.Log(Color.yellow.a); // Альфа-компонент желтого
    }
}
