using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looking : MonoBehaviour
{
    // Обращаемся к значениям Mouse X и Mouse Y в Unity (Input Manager) для исп. их в дальнейшем
    private readonly string MouseX = "Mouse X";
    private readonly string MouseY = "Mouse Y";

    // Задаем значения скорости камеры
    [SerializeField] private float _speed;

    // Объект камера
    [SerializeField] private Transform _camera;

    // Ссылка на объект тела игрока
    [SerializeField] private Transform _body;

    private void Update()
    {
        // Вращение камерой по оси Y - вверх и вниз
        _camera.Rotate(_speed * -Input.GetAxis(MouseY) * Time.deltaTime * Vector3.right);

        // Вращает объект (игрока) по оси X - лево и право
        _body.Rotate(_speed * Input.GetAxis(MouseX) * Time.deltaTime * Vector3.up);
    }
}