using UnityEngine;
using System.Collections;

public class BulletScriptTEST : MonoBehaviour {

    public float bulletSpeed;

    private GameObject TurretOBJ;

	// Use this for initialization
	void Start () 
    {
        TurretOBJ = GameObject.Find("Gun1 level 1");
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Translate(bulletSpeed, 0, 0 * Time.deltaTime);

        if (TurretOBJ.GetComponent<TurretTEST>().Fired == true)
        {
            this.gameObject.transform.rotation = TurretOBJ.transform.rotation;
        }

       

        //this.gameObject.transform.Translate(Vector2.right * bulletSpeed * Time.deltaTime); 


	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        //print("HELLO");
        if (col.gameObject.tag == "Border")
        {
            //print("Hello");

            Destroy(this.gameObject);
        }
    }

}
