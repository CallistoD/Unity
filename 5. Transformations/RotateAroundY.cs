using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundY : MonoBehaviour
{

    [SerializeField] private float _rotationSpeed;

    void Update()
    {
        RotateCubeAroundY();
    }

    private void RotateCubeAroundY()
    {
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
    }
}
