
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public GameObject player;
    public float speed = 1f;
    public int health = 2;
    void Start()
    {
        player = GameObject.Find("PlayerCapsule");
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z), speed * Time.deltaTime);
        if (health == 0) {
            EnemySpawner.currentEnemies--;
            Destroy(gameObject);
        }
    }
}