using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        ScaleUniformly();
    }

    private void ScaleUniformly()
    {
        transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
    }
}
