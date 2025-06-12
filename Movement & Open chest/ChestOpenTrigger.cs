using UnityEngine;

// �������� �� ���������� ������� �� ������� (������� ������ �)
public class ChestOpenTrigger : MonoBehaviour
{
    [SerializeField] private Chest _chest;

    // �������� ������ ������ ��� ���
    private bool _isOpened = false;
    private bool _hasOpener;

    // �������� ���������� �� ����� � ���� �������
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ChestOpener>())
        {
            _hasOpener = true;
            Debug.Log("Enter - " + _hasOpener);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<ChestOpener>())
        {
            _isOpened = false;
            Debug.Log("Exit - " + _isOpened);
        }
    }

    // �������� �������, ���� ������ ������ �� ������� �� ������
    // ���� �� ������ � � ���� ������� � ������ �, �� ������� ������
    private void Update()
    {
        if (_isOpened)
            return;

        if(_hasOpener && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E is pressed");
            _chest.Open();
            _isOpened = true;
        }
    }
}
