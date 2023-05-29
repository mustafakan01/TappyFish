using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    Rigidbody2D _rb;
    public float speed;
    //[SerializeField]
    //private float _speed;
    int angle;
    int maxAngle = 20;
    int minAngle = -60;
    public Score score;
    public GameManager manager;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        //_rb.velocity = new Vector2(_rb.velocity.x, 9f);
    }


    void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0) && GameManager.gameOver==false )
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Score"))
        {
            score.Scored();
        }
        else if (collision.CompareTag("Colum"))
        {
            manager.GameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (GameManager.gameOver==false)
            {
                manager.GameOver();

            }
            else
            {
                manager.GameOver();

            }
        }
    }
}
