using System.Collections;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    public Rigidbody targetRigidbody; // ������ �� ����, � �������� ����� �������������� ����
    public Vector3 force = new Vector3(0, 10, 0); // ����, �������������� � ����
    public float forceDuration = 2f; // ����� ���������� ���� � ��������
    public float waitDuration = 0.5f; // ����� �������� ����� ����������� ���� � ��������

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
            targetRigidbody.AddForce(force, ForceMode.Impulse); // ���������� ���� � ����
            yield return new WaitForSeconds(forceDuration); // �������� ��������� ������� ���������� ����
            targetRigidbody.velocity = Vector3.zero; // ��������� ���� (��� ����� ��������� ���������� ��-�������, ���� �����)
            yield return new WaitForSeconds(waitDuration); // �������� ����� ����������� ����
        }
    }
}