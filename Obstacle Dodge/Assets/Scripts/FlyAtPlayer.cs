using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private Transform player;

    Vector3 playerPosition;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    private void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }

    private void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
