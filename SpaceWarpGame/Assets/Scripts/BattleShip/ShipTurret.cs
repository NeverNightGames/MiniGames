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


    private TotalResources totResource;


    public bool playBattleMusic;


    public GameObject[] bsObj;


    public AudioClip shootSFX;

    AudioSource AS;


    bool canFire;

    // public BattleShip[] BScript;


    // Use this for initialization
    void Start()
    {
        totResource = GameObject.Find("Game Master").GetComponent<TotalResources>();

        bsObj = GameObject.FindGameObjectsWithTag("Battle Ship");

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

        if (enemyShips.Length == 0)
        {
            // print("Gone");

            playBattleMusic = false;
        }
        else
        {
            // print("SPAWN");

            playBattleMusic = true;

            if (canFire == false)
            {
                AS.clip = shootSFX;

                AS.Play();

                StartCoroutine(Fire());

                Instantiate(bulletOBJ, firePos1.transform.position, firePos1.transform.rotation);

                Instantiate(bulletOBJ, firePos2.transform.position, firePos2.transform.rotation);
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
