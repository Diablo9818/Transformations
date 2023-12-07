using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsula : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        ScaleCapsule();
    }

    private void ScaleCapsule()
    {
        transform.localScale += new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed) * Time.deltaTime;
    }
}
