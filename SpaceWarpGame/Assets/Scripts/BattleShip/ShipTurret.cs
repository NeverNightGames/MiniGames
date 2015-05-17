using UnityEngine;
using System.Collections;

public class ShipTurret : MonoBehaviour
{

    public GameObject[] enemyShips;

    public GameObject enemyShip;

    public Transform firePos1;

    public Transform firePos2;

    public GameObject bulletOBJ;

    public float turretMoveSpeed;

    // Use this for initialization
    void Start()
    {


        //enemyShip = GameObject.FindGameObjectWithTag("Enemy");

       // enemyShips = GameObject.FindGameObjectsWithTag("Enemy");

        //float angle = Mathf.Atan2(, lookPos.x) * Mathf.Rad2Deg;

    }

    // Update is called once per frame
    void Update()
    {
        enemyShips = GameObject.FindGameObjectsWithTag("Enemy");

        for (int i = 0; i < enemyShips.Length; i++)
        {
            Vector3 vectorToTarget = enemyShips[i].transform.position - transform.position;
            float angle = (Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg);
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * turretMoveSpeed);

            //print(enemyShips[i].name);

        }



        //Vector3 vectorToTarget = enemyShip.transform.position - transform.position;
        //float angle = (Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg);
        //Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        //transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * turretMoveSpeed);


        // transform.LookAt(transform.position + new Vector3(0, 0, 1), enemyShip.transform.position - transform.position);

        Instantiate(bulletOBJ, firePos1.transform.position, firePos1.transform.rotation);

        Instantiate(bulletOBJ, firePos2.transform.position, firePos2.transform.rotation);


    }
}
