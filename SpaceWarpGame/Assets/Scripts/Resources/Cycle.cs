using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Cycle : MonoBehaviour
{

    float timer;

    public float cycleTime;

    public int cycle;

    public Text cycleText;

    private BattleShipTEST Ship1;


	// Use this for initialization
	void Start () 
    {
        //print("TEST");

        Ship1 = GameObject.Find("Battle Ship 1").GetComponentInParent<BattleShipTEST>();
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        timer += Time.fixedDeltaTime;



        //Cycle
        if (timer >= cycleTime)
        {

            Ship1.BSEnergy += 20;

            Ship1.BSFood += 20;

            Ship1.BSAmmo += 20;

            

            cycle += 1;

            timer = 0;
        }

        cycleText.text = "Cycle " + cycle;

        

        


	
	}
}
