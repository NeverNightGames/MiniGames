using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {

    public float bulletSpeed;

    private GameObject TurretOBJ;

    public float bulletLifeTime;

    float timer = 0;

    float distance;

    GameObject Enemybulletparent;

	// Use this for initialization
	void Start () 
    {
        Enemybulletparent = GameObject.Find("Enemy Bullets");

        this.gameObject.transform.parent = Enemybulletparent.transform;

	
	}
	
	// Update is called once per frame
	void Update () 
    {


        distance = Random.Range(8, 16);

        Vector2 pos = new Vector2(distance, 0);

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
        if (col.gameObject.tag == "Battle Ship")
        {
            print("Enemy Bullet");

            Destroy(this.gameObject);
        }
    }
}
