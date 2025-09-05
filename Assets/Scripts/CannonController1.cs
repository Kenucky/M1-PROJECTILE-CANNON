using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController1 : MonoBehaviour
{
    public GameObject cannonballPrefab;
    public Transform cannonballSpawnPoint;
    public float launchAcceleration = 10f;
    public float initialVelocity = 5f;



    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireProjectile();
        }
    }

    // Update is called once per frame
    void FireProjectile()
    {
        GameObject projectile = Instantiate(cannonballPrefab, cannonballSpawnPoint.position, Quaternion.identity);

        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            float time = 1f;
            Vector3 launchForce = (0.5f * launchAcceleration * time * time + initialVelocity * time) * cannonballSpawnPoint.forward;
            rb.AddForce(launchForce, ForceMode.Impulse);
        }
    }
}
