using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Cycle : MonoBehaviour
{

    float timer;

    public float cycleTime;

    public int cycle;

    public Text cycleText;


    private MotherShipTest MSScript;

    private BattleShipTEST Ship1;

    private TotalResources totResources;




    // Use this for initialization
    void Start()
    {
        //print("TEST");

        //MSScript = GameObject.Find("MotherShip").GetComponent<MotherShipTest>();

        //Ship1 = GameObject.Find("Battle Ship 1").GetComponentInParent<BattleShipTEST>();

        totResources = GameObject.Find("Game Master").GetComponentInParent<TotalResources>();

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.fixedDeltaTime;




        //Cycle
        if (timer >= cycleTime)
        {

            // Gave 

            totResources.BattleShip1.BSEnergy -= 25;

            if (totResources.BattleShip1.updatedEnergy == false)
            {
                totResources.BattleShip1.BSEnergy += 20;
            }
            else if (totResources.BattleShip1.updatedEnergy == true)
            {
                totResources.BattleShip1.BSEnergy += 30;
            }



            cycle += 1;

            timer = 0;

        }

        cycleText.text = "Cycle " + cycle;







    }
}
