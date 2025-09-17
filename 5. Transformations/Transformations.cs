using UnityEngine;

public class Transformations : MonoBehaviour
{
    [SerializeField] private bool _moveSphereForward;
    [SerializeField] private bool _rotateCubeAroundY;
    [SerializeField] private bool _scaleCapsule;
    [SerializeField] private bool _transformCubeComposite;

    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _scaleSpeed = 0.5f;

    private float _movementSpeed = 2f;

    void Update()
    {
        ApplyTransformOperations();
    }

    private void ApplyTransformOperations()
    {
        if (_moveSphereForward) MoveSphereForward();
        if (_rotateCubeAroundY) RotateCubeAroundY();
        if (_scaleCapsule) ScaleCapsule();
        if (_transformCubeComposite) TransformCubeComposite();
    }

    private void MoveSphereForward()
    {
        Debug.Log("START: MoveSphereForward");

        transform.Translate(Vector3.forward * _movementSpeed * Time.deltaTime);
    }

    private void RotateCubeAroundY()
    {
        Debug.Log("START: RotateCubeAroundY");

        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
    }

    private void ScaleCapsule()
    {
        Debug.Log("START: ScaleCapsule");

        transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
    }

    private void TransformCubeComposite()
    {
        Debug.Log("START: TransformCubeComposite");

        RotateCubeAroundY();

        transform.position += Vector3.right * _movementSpeed * Time.deltaTime;
        transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
    }
}
