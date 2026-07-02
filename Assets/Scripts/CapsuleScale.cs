using System;
using UnityEngine;

public class CapsuleScale : MonoBehaviour
{
    [SerializeField] private Transform _capsule;
    [SerializeField] private float _speed;
    void Update()
    {
        _capsule.localScale += (transform.localScale * _speed * Time.deltaTime); 
    }
}
