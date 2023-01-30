
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public Transform player;
    public float speed = 1f;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }
}