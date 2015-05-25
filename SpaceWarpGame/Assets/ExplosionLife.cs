using UnityEngine;
using System.Collections;

public class ExplosionLife : MonoBehaviour
{

    public float lifeTime;

    float timer;

    BattleShip BS;

    GameObject[] battleShipOBJ;

    // Use this for initialization
    void Start()
    {
        battleShipOBJ = GameObject.FindGameObjectsWithTag("Battle Ship");

        for (int i = 0; i < battleShipOBJ.Length; i++)
        {
            BS = battleShipOBJ[i].GetComponent<BattleShip>();
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (BS.createExplosion == true)
        {
            timer += Time.fixedDeltaTime;

            if (timer >= lifeTime)
            {
                Destroy(this.gameObject);

                BS.createExplosion = false;
            }

            //timer = 0;
        }

        print(timer);

    }
}
