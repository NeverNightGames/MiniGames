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


   // public float shootTime;

    //float timer;

    bool canFire;


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

        if (battleShips.Length == 0)
        {
            print("Game Over");
        }
        else
        {

          
            for (int i = 0; i < battleShips.Length; i++)
            {
                Vector3 vectorToTarget = battleShips[i].transform.position - transform.position;
                float angle = (Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg);
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * turretMoveSpeed);

              

                if (canFire == false)
                {
                    StartCoroutine(Fire());

                    Instantiate(bullet, shootArea.transform.position, shootArea.transform.rotation);

                    
                }
                
            }

        }

    }

    IEnumerator Fire()
    {
        canFire = true;
        yield return new WaitForSeconds(0.25f);
        canFire = false;
        
    }

    
}




