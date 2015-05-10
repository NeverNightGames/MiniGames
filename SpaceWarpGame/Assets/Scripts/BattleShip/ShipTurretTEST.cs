using UnityEngine;
using System.Collections;

public class ShipTurretTEST : MonoBehaviour {

    private GameObject enemyShip;

	// Use this for initialization
	void Start () 
    {
        enemyShip = GameObject.Find("Enemy Spaceship");

        

        //float angle = Mathf.Atan2(, lookPos.x) * Mathf.Rad2Deg;
	
	}
	
	// Update is called once per frame
	void Update () 
    {
       // Vector2 enemyPos = new Vector2(enemyShip.transform.position.x,enemyShip.transform.position.y);

        
       // float angle = Mathf.Atan2(enemyPos.x, enemyPos.y) * Mathf.Rad2Deg;

       // float angle = Mathf.Atan(enemyPos.y) * Mathf.Rad2Deg;

       // transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        //transform.LookAt(enemyShip.transform);
	
	}
}
