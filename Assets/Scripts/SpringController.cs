using UnityEngine;

public class ApplyForcePeriodically : MonoBehaviour
{
    public Rigidbody targetRigidbody;
    public Vector3 force = new Vector3(0, 10, 0);
    public float interval = 2.0f;

    private float timer;

    void Start()
    {
        if (targetRigidbody == null)
        {
            targetRigidbody = GetComponent<Rigidbody>();
        }
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            ApplyForce();
            timer = 0.0f;
        }
    }

    void ApplyForce()
    {
        if (targetRigidbody != null)
        {
            targetRigidbody.AddForce(force, ForceMode.Impulse);
        }
        else
        {
            Debug.LogWarning("No Rigidbody attached to the target object.");
        }
    }
}