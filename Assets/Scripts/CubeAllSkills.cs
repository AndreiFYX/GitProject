using UnityEngine;

public class CubeAllSkills : MonoBehaviour
{
    [SerializeField] private Transform _cube;
    [SerializeField] private float _speedRun;
    [SerializeField] private float _speedScale;

    private void Update()
    {
        _cube.Rotate(0, 10, 0);
        _cube.position += (Vector3.back * _speedRun * Time.deltaTime);
        _cube.localScale += (transform.localScale * _speedScale * Time.deltaTime);
    }
}