using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondParticleActivator : MonoBehaviour
{
    public ParticleSystem _Ps;


    private void OnTriggerEnter(Collider other)
    {
        _Ps.Play();
    }
}
