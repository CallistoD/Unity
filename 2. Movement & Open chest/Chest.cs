using UnityEngine;

// Анимайция сундука по тригеру
public class Chest : MonoBehaviour
{
    private readonly int OpenTrigger = Animator.StringToHash("Open");

    [SerializeField] private Animator _animator;

    public void Open()
    {
        _animator.SetTrigger(OpenTrigger);
        Debug.Log("Open");
    }
}
