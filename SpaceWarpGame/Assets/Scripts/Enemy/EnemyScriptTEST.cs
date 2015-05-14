using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyScriptTEST : MonoBehaviour {

    public float enemySpeed;


    public Slider enemyHealthBar;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
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
            print("Enemy Gone");

            Destroy(this.gameObject);
        }
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            //print("ENEMY");

            enemyHealthBar.value--;
        }

        if (col.gameObject.tag == "Border")
        {
            print("HIT");
        }

        //if (col.gameObject.tag == "Ship Range")
        //{
        //    print("HIT");
        //}
    }
}
