using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telekinesis : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody _rigidbody;
    private int _acceleration = 5;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Move(Vector3.up);
        }
        else if(Input.GetKey(KeyCode.Space))
        {
            _speed = _speed + _acceleration;
            Move(Vector3.forward);
        }
    }

    private void Move(Vector3 direction)
    {
        _rigidbody.AddForce(direction * _speed);
    }
}
