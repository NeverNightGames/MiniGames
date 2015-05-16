using UnityEngine;
using System.Collections;

public class EnemyWave : MonoBehaviour {

    public GameObject[] EnemyOBJS;

    public Transform[] spawnPos;

	// Use this for initialization
	void Start () 
    {
       

        for (int i = 0; i < EnemyOBJS.Length; i++)
        {
            Quaternion enemRo = EnemyOBJS[i].transform.rotation;

            Instantiate(EnemyOBJS[i], spawnPos[i].position, enemRo);
        }
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        

	
	}
}
