using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; //movement speed
    public float rotationSpeed = 200f; //rotation speed


    void Update()
    {
        //get input for movement
        float moveForward = Input.GetAxis("Vertical");
        float moveSide = Input.GetAxis("Horizontal");

        //move player
        Vector3 move = new Vector3(moveSide, 0f, moveForward) * moveSpeed * Time.deltaTime;
        transform.Translate(move, Space.World);


    }


}
