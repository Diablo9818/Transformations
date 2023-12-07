using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private float _movingSpeed;

    private void Update()
    {
        MoveSphere();
    }

    private void MoveSphere()
    {
        transform.Translate(Vector3.forward * _movingSpeed * Time.deltaTime);
    }
}
