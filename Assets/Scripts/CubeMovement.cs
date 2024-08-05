using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed = 5f; // скорость движения
    public float rotationSpeed = 100f; // скорость вращения

    void Update()
    {
        // Получаем ввод с клавиатуры
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Рассчитываем движение и вращение
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 rotation = new Vector3(0, moveHorizontal, 0);

        // Применяем движение и вращение к объекту
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);
    }
}