using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCylinder : MonoBehaviour
{

    [SerializeField] private Vector3 _rotator;
    private void Update()
    {
        transform.Rotate(_rotator * Time.deltaTime);
    }
}
