using UnityEngine;
using System.Collections;

public class EnemyWave : MonoBehaviour
{


    public float timerToAttack;

    float timer;

    public bool canAttack;

    public GameObject[] EnemyOBJS;

    public Transform[] spawnPos;


    // public bool enAttacking;

    // Use this for initialization
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.fixedDeltaTime;

        if (timer >= timerToAttack)
        {
            canAttack = true;


        }

        if (canAttack == true)
        {

            for (int i = 0; i < EnemyOBJS.Length; i++)
            {
                Quaternion enemRo = EnemyOBJS[i].transform.rotation;

                Instantiate(EnemyOBJS[i], spawnPos[i].position, enemRo);
            }

            print("Wave");

            canAttack = false;

            timer = 0;
        }


    }
}
