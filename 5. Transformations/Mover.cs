using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _movementSpeed = 2f;

    private void Update()
    {
        MoveRight();
    }

    private void MoveRight()
    {
        transform.position += Vector3.right * _movementSpeed * Time.deltaTime;
    }
}
