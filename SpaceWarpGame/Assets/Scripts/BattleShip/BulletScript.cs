using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour
{

    public float bulletSpeed;

    private GameObject TurretOBJ;

    public float bulletLifeTime;

    float timer = 0;

    float distance;

    GameObject bulletparent;

    // Use this for initialization
    void Start()
    {
        TurretOBJ = GameObject.Find("Gun1 level 1");

        bulletparent = GameObject.Find("Bullets Parent");

        this.gameObject.transform.parent = bulletparent.transform;

    }

    // Update is called once per frame
    void Update()
    {


        distance = Random.Range(8,16);

        Vector2 pos = new Vector2(distance,0);

        //transform.position = (pos);

        transform.Translate(distance, 0, 0);

        //  this.gameObject.GetComponent<Rigidbody2D>().AddForce(this.gameObject.transform.forward * bulletSpeed);

        timer += Time.fixedDeltaTime;

        if (timer >= bulletLifeTime)
        {
            Destroy(this.gameObject);

            timer = 0;

           //  print("DEAD");
        }

    }

 

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
           // print("Bullet");

            Destroy(this.gameObject);
        }

        if (col.gameObject.tag == "Battle Ship")
        {
            Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        if (col.gameObject.tag == "MotherShip")
        {
            Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }

}
