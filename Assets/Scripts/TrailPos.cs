using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailPos : MonoBehaviour
{
    [SerializeField] private Transform _Player;
    private void Update()
    {
        this.gameObject.transform.position = new Vector3(_Player.transform.position.x, 0.2f, _Player.transform.position.z);
    }
}
