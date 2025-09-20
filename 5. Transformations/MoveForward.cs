using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Invector.vCharacterController.vThirdPersonMotor;

public class MoveForward : MonoBehaviour
{
    private float _movementSpeed = 2f;

    void Update()
    {
        MoveSphereForward();
    }

    private void MoveSphereForward()
    {
        transform.position += Vector3.right * _movementSpeed * Time.deltaTime;
    }
}
