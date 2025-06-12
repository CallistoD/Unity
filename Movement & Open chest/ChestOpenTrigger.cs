using UnityEngine;

// Отвечает за открывание сундука по тригеру (нажатие кнопки Е)
public class ChestOpenTrigger : MonoBehaviour
{
    [SerializeField] private Chest _chest;

    // Првоерка открыт сундук или нет
    private bool _isOpened = false;
    private bool _hasOpener;

    // Проверка находиться ли игрок в зоне тригера
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

    // Открытие сундука, если сундук открыт то выходим из метода
    // если он закрыт и в зоне тригера и нажата Е, то открыть сундук
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
