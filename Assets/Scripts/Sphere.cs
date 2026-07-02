using Unity.VisualScripting;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private Transform _sphere;
    [SerializeField] private float speed;

    void Update()
    {
        _sphere.position += (transform.forward * speed * Time.deltaTime);
    }
}
