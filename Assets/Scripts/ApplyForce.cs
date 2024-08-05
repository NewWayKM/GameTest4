using System.Collections;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    public Rigidbody targetRigidbody; // Ссылка на тело, к которому будет прикладываться сила
    public Vector3 force = new Vector3(0, 10, 0); // Сила, прикладываемая к телу
    public float forceDuration = 2f; // Время приложения силы в секундах
    public float waitDuration = 0.5f; // Время ожидания между приложением силы в секундах

    void Start()
    {
        if (targetRigidbody != null)
        {
            StartCoroutine(ApplyForceRoutine());
        }
        else
        {
            Debug.LogError("Target Rigidbody is not assigned!");
        }
    }

    IEnumerator ApplyForceRoutine()
    {
        while (true)
        {
            targetRigidbody.AddForce(force, ForceMode.Impulse); // Приложение силы к телу
            yield return new WaitForSeconds(forceDuration); // Ожидание окончания времени приложения силы
            targetRigidbody.velocity = Vector3.zero; // Остановка тела (или можно применить торможение по-другому, если нужно)
            yield return new WaitForSeconds(waitDuration); // Ожидание между приложением силы
        }
    }
}