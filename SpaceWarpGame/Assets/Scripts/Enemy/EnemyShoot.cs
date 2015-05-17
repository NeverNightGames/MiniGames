using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour
{

    public GameObject[] battleShips;

    private GameObject Turet;

    private GameObject motherShip;

    Vector3 motherShipPos;

    public GameObject shootArea;

    public GameObject bullet;

    public float turretMoveSpeed;

    // Use this for initialization
    void Start()
    {
        

        motherShip = GameObject.Find("MotherShip");

        Turet = GameObject.Find("Enemy Gun");

    }

    // Update is called once per frame
    void Update()
    {
        battleShips = GameObject.FindGameObjectsWithTag("Battle Ship");

        for (int i = 0; i < battleShips.Length; i++)
        {
            Vector3 vectorToTarget = battleShips[i].transform.position - transform.position;
            float angle = (Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg);
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * turretMoveSpeed);
        }


         Instantiate(bullet, shootArea.transform.position, shootArea.transform.rotation);



    }
}
