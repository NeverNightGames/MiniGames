using UnityEngine;
using System.Collections;

public class BulletScriptTEST : MonoBehaviour
{

    public float bulletSpeed;

    private GameObject TurretOBJ;

    public float bulletLifeTime;

    float timer = 0;

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
        transform.Translate(bulletSpeed, 0, 0 * Time.deltaTime);

        //  this.gameObject.GetComponent<Rigidbody2D>().AddForce(this.gameObject.transform.forward * bulletSpeed);

        timer += Time.fixedDeltaTime;

        if (timer >= bulletLifeTime)
        {
            Destroy(this.gameObject);

            timer = 0;

           //  print("DEAD");
        }



    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //print("HELLO");
        if (col.gameObject.tag == "Border")
        {
           // print("Hello");

            Destroy(this.gameObject);
        }

        if (col.gameObject.tag == "Enemy")
        {
            print("Bullet");
        }



    }

}
