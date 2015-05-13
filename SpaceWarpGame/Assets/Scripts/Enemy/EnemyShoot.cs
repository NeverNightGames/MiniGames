using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour
{


    private GameObject Turet;


    private GameObject motherShip;

    Vector3 motherShipPos;

    // Use this for initialization
    void Start()
    {
       motherShip = GameObject.Find("MotherShip");

        Turet = GameObject.Find("Enemy Gun");

    }

    // Update is called once per frame
    void Update()
    {


        motherShipPos = new Vector3(motherShip.transform.position.x, motherShip.transform.position.y, 0);

        float angle1 = Mathf.Atan2(motherShipPos.y,motherShipPos.x) * Mathf.Rad2Deg;

        //float angle2 = Mathf.Atan2(motherShipPos.x, motherShipPos.y) * Mathf.Rad2Deg;

         Turet.transform.rotation = Quaternion.AngleAxis(angle1, Vector3.forward);


       // Turet.transform.rotation = Quaternion.AngleAxis(angle2, Vector3.forward);



    }
}
