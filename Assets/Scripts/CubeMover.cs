using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField] private float _movingSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        MoveAndGrowCube();
    }

    private void MoveAndGrowCube()
    {
        transform.Translate(Vector3.forward * _movingSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
        transform.localScale += new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed) * Time.deltaTime;
    }
}
