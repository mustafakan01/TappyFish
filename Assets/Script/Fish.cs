using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    Rigidbody2D _rb;
    public float speed;
    //[SerializeField]
    //private float _speed;
    float angle;
    float maxAngle;
    float minAngle;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        //_rb.velocity = new Vector2(_rb.velocity.x, 9f);
    }


    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _rb.velocity = new Vector2(_rb.velocity.x, speed);
        }
        if (_rb.velocity.y > 0)
        {
            if (angle <= maxAngle)
            {
                angle = angle + 4;
            }
        }
        else if (_rb.velocity.y < -2.5f)
        {
            if (angle > minAngle)
            {
                angle = angle - 2;
            }
        }
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
