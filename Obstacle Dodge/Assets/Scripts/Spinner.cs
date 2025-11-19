using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float xAngle = 0f;
    [SerializeField] private float yAngle = 0f;
    [SerializeField] private float zAngle = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(xAngle * Time.deltaTime, yAngle * Time.deltaTime, zAngle * Time.deltaTime);
    }
}
