using UnityEngine;
using System.Collections;

public class EnemyScriptTEST : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {

	
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
