using UnityEngine;

public class PingPongMovement : MonoBehaviour
{
    // Дистанция движения (может быть отрицательной)
    public float distance = 5.0f;
    // Скорость движения
    public float speed = 2.0f;

    // Начальная позиция объекта
    private Vector3 startPosition;

    void Start()
    {
        // Сохранение начальной позиции объекта в мировых координатах
        startPosition = transform.position;
    }

    void Update()
    {
        // Вычисление новой позиции объекта в мировых координатах
        float newZ = startPosition.z + Mathf.PingPong(Time.time * speed, Mathf.Abs(distance) * 2) - Mathf.Abs(distance);
        transform.position = new Vector3(startPosition.x, startPosition.y, newZ);
    }
}