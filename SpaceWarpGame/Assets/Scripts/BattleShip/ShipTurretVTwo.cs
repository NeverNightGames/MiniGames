using UnityEngine;
using System.Collections;

public class ShipTurretVTwo : MonoBehaviour
{

    public GameObject[] enemyShips;

    public GameObject enemyShip;


    public Transform firePos1;

    public Transform firePos2;

    public Transform firePos3;

    public Transform firePos4;


    public GameObject bulletOBJ;


    public float turretMoveSpeed;


    private TotalResources totResource;

    bool canFire;

    public AudioClip ShootSFX;

    AudioSource AS;


    // Use this for initialization
    void Start()
    {
        AS = this.gameObject.GetComponent<AudioSource>();
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

        if (enemyShips.Length >= 1)
        {

            if (canFire == false)
            {
                AS.clip = ShootSFX;

                AS.Play();

                StartCoroutine(Fire());

                Instantiate(bulletOBJ, firePos1.transform.position, firePos1.transform.rotation);

                Instantiate(bulletOBJ, firePos2.transform.position, firePos2.transform.rotation);

                Instantiate(bulletOBJ, firePos3.transform.position, firePos3.transform.rotation);

                Instantiate(bulletOBJ, firePos4.transform.position, firePos4.transform.rotation);
            }
        }

    }

    IEnumerator Fire()
    {
        canFire = true;
        yield return new WaitForSeconds(0.20f);
        canFire = false;


    }
}
