using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    BoxCollider2D box;
    float groundWidht;
    float obsticleWidht;

    void Start()
    {

        if (gameObject.CompareTag("Ground"))
        {

            box = GetComponent<BoxCollider2D>();
            groundWidht = box.size.x;
        }
        else if (gameObject.CompareTag("Obsticle"))
        {
            obsticleWidht=GameObject.FindGameObjectWithTag("Colum").GetComponent<BoxCollider2D>().size.x;
        }
    }

    void Update()
    {
        if (GameManager.gameOver==false)
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }

        if (gameObject.CompareTag("Ground"))
        {
            if (transform.position.x <= -groundWidht)
            {
                transform.position = new Vector2(transform.position.x + 2 * groundWidht, transform.position.y);
            }
        }
        else if (gameObject.CompareTag("Obsticle"))
        {
            if (transform.position.x<GameManager.bottomleft.x-obsticleWidht)
            {
                Destroy(gameObject);
            }
        }

       
    }
}
