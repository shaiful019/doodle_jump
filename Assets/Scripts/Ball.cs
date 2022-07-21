using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float _speed = 20f;
    Rigidbody _rigitbody;
    Vector3 _velocity;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigitbody = GetComponent<Rigidbody>();
        _rigitbody.velocity = Vector3.down * _speed;
    }

    // Update is called once per frame

    void FixedUpdate()
    {
        _rigitbody.velocity = _rigitbody.velocity.normalized * _speed;
        _velocity = _rigitbody.velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        _rigitbody.velocity = Vector3.Reflect(_velocity, collision.contacts[0].normal);
    }
}
