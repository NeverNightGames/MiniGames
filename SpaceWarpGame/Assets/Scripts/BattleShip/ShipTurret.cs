using UnityEngine;
using System.Collections;

public class ShipTurret : MonoBehaviour {

    public Transform enemyShip;

	// Use this for initialization
	void Start () 
    {
        

        

        //float angle = Mathf.Atan2(, lookPos.x) * Mathf.Rad2Deg;
	
	}
	
	// Update is called once per frame
	void Update () 
    {

        Vector3 enemyPos = enemyShip.transform.position;

       // enemyPos.z = 32;

       // Vector3 lookPos = Camera.main.ScreenToWorldPoint(enemyPos);

        float angle = Mathf.Atan2(enemyPos.y, enemyPos.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(angle, Vector3.right);


	
	}
}
