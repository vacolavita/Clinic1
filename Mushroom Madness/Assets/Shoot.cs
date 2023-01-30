using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float fireRate;
    public GameObject projectilePrefab;
    private float fireDelay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fireDelay <= 0 && Input.GetMouseButton(0))
        {
            GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
            projectile.transform.Translate(new Vector3(0, -0.5f, 0));
            projectile.transform.Translate(Vector3.forward);
            Rigidbody shotBody = projectile.GetComponent<Rigidbody>();
            shotBody.AddRelativeForce(Vector3.forward * 40, ForceMode.Impulse);
            fireDelay = fireRate;
        }
        fireDelay -= Time.deltaTime;

    }
}
