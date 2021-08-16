using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    Rigidbody2D car;
    public GameCtrl gameCtrl;


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

        //Vector2 move = new Vector2(dx, dy);
        //car.AddForce(move * speed); // ¬I¥[¤O¶q

        Vector2 move = new Vector2(dx, dy);
        car.velocity = move * speed;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Booomb"))
        {
            collision.gameObject.SetActive(false);
            //Destroy(collision.gameObject);
            gameCtrl.AddScore(1);

            StartCoroutine(GenBomb(collision.gameObject));
        }
    }

    IEnumerator GenBomb(GameObject obj)
    {
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        yield return new WaitForSeconds(20);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);

        if (!gameCtrl.win.IsActive())
        {
            obj.SetActive(true);
            gameCtrl.AddBomb();
        }
    }

}
