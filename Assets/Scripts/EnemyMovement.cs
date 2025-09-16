using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float areaSize = 10f;
    public float stopDistance = 0.2f;

    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        PickNewTarget();
    }

    // Update is called once per frame
    void Update()
    {
        //move towards the target
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        //checks if close enough to pick a target
        if (Vector3.Distance(transform.position, targetPosition) < stopDistance)
        {
            PickNewTarget();
        }

    }
    

    void PickNewTarget()
    {
        float randomX = Random.Range(-areaSize, areaSize);
        float randomZ = Random.Range(-areaSize, areaSize);
        targetPosition = new Vector3(randomX, transform.position.y, randomZ);
    }


}
