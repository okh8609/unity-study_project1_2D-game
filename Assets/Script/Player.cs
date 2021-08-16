using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    Rigidbody2D car;

    // Start is called before the first frame update
    void Start()
    {
        car = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal");
        float dy = Input.GetAxis("Vertical");
        //if (dx != 0.0f || dy != 0.0f)
        //    print(dx.ToString() + " ; " + dy.ToString());

        //Vector2 move = new Vector2(dx, dy);
        //car.AddForce(move * speed); // ¬I¥[¤O¶q

        Vector2 move = new Vector2(dx, dy);
        car.velocity = move * speed;

        //if (transform.position.x > 10 || transform.position.x < -10 ||
        //    transform.position.y > 5 || transform.position.y < -5)
        //    transform.SetPositionAndRotation(new Vector3(0, 0, 0), new Quaternion());

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Booomb"))
            collision.gameObject.SetActive(false);
            //Destroy(collision.gameObject);
    }

}
