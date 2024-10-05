using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamerController : MonoBehaviour
{
    public float Speed;
    public float Jump;
    public Rigidbody2D Body;
    private bool Graunded;
    private bool TwoJump;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Place"))
        {
            Graunded = true;
            TwoJump = false;
        }
    }
    // Перемещение объекта
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Graunded == true)
            {
                Body.velocity = new Vector3(Body.velocity.x, 0, Body.velocity.y);
                Body.AddForce(new Vector3(0, Jump, 0));
                Graunded = false;


            }
            else if (TwoJump == false)
            {
                Body.velocity = new Vector3(Body.velocity.x, 0, Body.velocity.y);
                Body.AddForce(new Vector3(0, Jump, 0));
                TwoJump = true;

            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(Speed * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(Speed * Time.deltaTime, 0, 0);
        }
    }
}
