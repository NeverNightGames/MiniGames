using UnityEngine;
using System.Collections;

public class EnemyScriptTEST : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Translate(0.2f,0, 0);

	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            print("ENEMY");
        }

        if (col.gameObject.tag == "Ship Range")
        {
            print("HIT");
        }
    }
}
