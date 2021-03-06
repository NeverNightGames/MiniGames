﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyScript : MonoBehaviour
{

    public float enemySpeed;

    public Slider enemyHealthBar;

    public GameObject enemyParent;


    // Use this for initialization
    void Start()
    {
        enemyHealthBar = this.gameObject.GetComponentInChildren<Slider>();

        enemyParent = GameObject.Find("Enemies");

        this.gameObject.transform.parent = enemyParent.transform;

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(enemySpeed,0, 0 * Time.fixedDeltaTime);

        GetComponent<Rigidbody2D>().velocity = new Vector2(-enemySpeed, 0);

        enemyHealthBar.fillRect.GetComponent<Image>().color = Color.green;

        if (enemyHealthBar.value <= 50 && enemyHealthBar.value >= 26)
        {
            enemyHealthBar.fillRect.GetComponent<Image>().color = Color.yellow;
        }
        else if (enemyHealthBar.value <= 25)
        {
            enemyHealthBar.fillRect.GetComponent<Image>().color = Color.red;
        }

        if (enemyHealthBar.value <= 1)
        {
            //print("Enemy Gone");

            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Battle Ship")
        {
            Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        if (col.gameObject.tag == "MotherShip")
        {
            Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        if (col.gameObject.tag == "Enemy")
        {
            Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            enemyHealthBar.value--;
        }

        if (col.gameObject.tag == "Bullet V2")
        {
            enemyHealthBar.value -= 10;
        }

        if (col.gameObject.tag == "Border")
        {
            Destroy(this.gameObject);
        }
    }
}
