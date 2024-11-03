using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    [SerializeField] private float _mouseSensitivity;

    private Vector3 _movementVector;
    private float _yRotation;


    private void Update()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        _movementVector = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        _rigidbody.velocity = transform.TransformDirection(_movementVector * (_speed * Time.deltaTime));
    }

    private void Rotate()
    {
        _yRotation = Input.GetAxis("Mouse X") * _mouseSensitivity;
        transform.Rotate(0f, _yRotation, 0f);
    }
}
