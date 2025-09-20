using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    void Update()
    {
        ScaleCapsule();
    }

    private void ScaleCapsule()
    {
        transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
    }
}
