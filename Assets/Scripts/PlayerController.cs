using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float _force = 20;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        PointMove();
    }

    private void PointMove()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                var point = new Vector3(hit.point.x, 1, hit.point.z);
                var direction = (point - transform.position).normalized;
                _rigidbody.AddForce(direction * _force);
            }
        }
      
        
    }
}
