using System;
using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    [SerializeField] private Transform _capsule;
    [SerializeField] private float _speed;
   private void Update()
    {
        _capsule.localScale += (transform.localScale * _speed * Time.deltaTime); 
    }
}