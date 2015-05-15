using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Cycle : MonoBehaviour
{

    float timer;

    public float cycleTime;

    public int cycle;

    public Text cycleText;


    private MotherShip MSScript;

    private BattleShip Ship1;

    private TotalResources totResources;

    public UpgradeResource upgradeRes;




    // Use this for initialization
    void Start()
    {
        //print("TEST");

        // MSScript = GameObject.Find("MotherShip").GetComponent<MotherShip>();

        //Ship1 = GameObject.Find("Battle Ship 1").GetComponentInParent<BattleShipTEST>();

        upgradeRes = GameObject.Find("Battle Ship 1").GetComponent<UpgradeResource>();

        totResources = this.gameObject.GetComponentInParent<TotalResources>();

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.fixedDeltaTime;




        //Cycle
        if (timer >= cycleTime)
        {

            // Gave 

            totResources.MSScript.MSEnergy -= 100;

            totResources.MSScript.MSFood -= 100;



            //

            switch (upgradeRes.energyLevel)
            {
                case 1:
                    totResources.MSScript.MSEnergy += 25;
                    break;
                case 2:
                    totResources.MSScript.MSEnergy += 50;
                    break;
                case 3:
                    totResources.MSScript.MSEnergy += 100;
                    break;
                case 4:
                    totResources.MSScript.MSEnergy += 175;
                    break;
                default:
                    print("ERROR");
                    break;
            }

            switch (upgradeRes.foodLevel)
            {
                case 1:
                    totResources.MSScript.MSFood += 50;
                    break;
                case 2:
                    totResources.MSScript.MSFood += 100;
                    break;
                case 3:
                    totResources.MSScript.MSFood += 150;
                    break;
                case 4:
                    totResources.MSScript.MSFood += 175;
                    break;
                default:
                    print("ERROR");
                    break;
            }

            switch (upgradeRes.ammoLevel)
            {


                case 1:
                    totResources.MSScript.MSAmmo += 25;
                    break;
                case 2:
                    totResources.MSScript.MSAmmo += 50;
                    break;
                case 3:
                    totResources.MSScript.MSAmmo += 75;
                    break;
                case 4:
                    totResources.MSScript.MSAmmo += 100;
                    //canUpgradeAmmo = false;
                    break;
                default:
                    print("ERROR");
                    break;


            }




            cycle += 1;

            timer = 0;

        }

        cycleText.text = "Cycle " + cycle;







    }
}
