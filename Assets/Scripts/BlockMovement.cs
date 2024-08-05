using UnityEngine;

public class PingPongMovement : MonoBehaviour
{
    // ��������� �������� (����� ���� �������������)
    public float distance = 5.0f;
    // �������� ��������
    public float speed = 2.0f;

    // ��������� ������� �������
    private Vector3 startPosition;

    void Start()
    {
        // ���������� ��������� ������� ������� � ������� �����������
        startPosition = transform.position;
    }

    void Update()
    {
        // ���������� ����� ������� ������� � ������� �����������
        float newZ = startPosition.z + Mathf.PingPong(Time.time * speed, Mathf.Abs(distance) * 2) - Mathf.Abs(distance);
        transform.position = new Vector3(startPosition.x, startPosition.y, newZ);
    }
}