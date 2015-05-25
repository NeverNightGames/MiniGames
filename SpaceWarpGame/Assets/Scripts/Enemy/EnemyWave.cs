using UnityEngine;
using System.Collections;

public class EnemyWave : MonoBehaviour
{


    public float timerToAttack;

    float timer;

    public bool canAttack;

    public GameObject[] EnemyOBJS;

    public Transform[] spawnPos;


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

                float spawnY = Random.Range(0, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
                //float spawnX = Random.Range(0, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,0)).x);
                Vector2 spawnPosition = new Vector2(Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x, spawnY);

                spawnPos[i].transform.position = spawnPosition;

                Instantiate(EnemyOBJS[i], spawnPos[i].position, enemRo);

            }

            // print("Wave");

            canAttack = false;

            timer = 0;
        }


    }
}
