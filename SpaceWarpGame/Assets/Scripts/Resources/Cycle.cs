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


    public UpgradeResource[] BSUpgradeResource;

    private GameObject[] bShipOBJ;


    private TotalResources totResources;


    public int level1EnergyUpgrade;

    public int level2EnergyUpgrade;

    public int level3EnergyUpgrade;

    public int level4EnergyUpgrade;


    public int level1FoodUpgrade;

    public int level2FoodUpgrade;

    public int level3FoodUpgrade;

    public int level4FoodUpgrade;

   








    // Use this for initialization
    void Start()
    {

        //upgradeRes = GameObject.Find("Battle Ship 1").GetComponent<UpgradeResource>();

        totResources = this.gameObject.GetComponentInParent<TotalResources>();

        bShipOBJ = GameObject.FindGameObjectsWithTag("Battle Ship");

        for (int i = 0; i < bShipOBJ.Length; i++)
        {
            BSUpgradeResource[i] = bShipOBJ[i].GetComponent<UpgradeResource>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.fixedDeltaTime;


        //print(totResources.totalEnergy);


        //Cycle
        if (timer >= cycleTime)
        {

            // 

            totResources.totalEnergy -= 100;

            totResources.totalFood -= 100;

            //for (int i = 0; i < BSUpgradeResource.Length; i++)
            //{
            //}

            ResourceEnergyLevelUpgrade();

            ResourceFoodLevelUpgrade();
            
   













            cycle += 1;

            timer = 0;

        }

        cycleText.text = "Cycle " + cycle;







    }

    void ResourceEnergyLevelUpgrade()
    {

        switch (BSUpgradeResource[0].energyLevel)
        {
            case 1:
                bShipOBJ[0].GetComponent<BattleShip>().BSEnergy += level1EnergyUpgrade;
                break;
            case 2:
                bShipOBJ[0].GetComponent<BattleShip>().BSEnergy += level2EnergyUpgrade;
                break;
            case 3:
                bShipOBJ[0].GetComponent<BattleShip>().BSEnergy += level3EnergyUpgrade;
                break;
            case 4:
                bShipOBJ[0].GetComponent<BattleShip>().BSEnergy += level4EnergyUpgrade;
                break;
            default:
                print("ERROR!");
                break;
        }

        switch (BSUpgradeResource[1].energyLevel)
        {
            case 1:
                bShipOBJ[1].GetComponent<BattleShip>().BSEnergy += level1EnergyUpgrade;
                break;
            case 2:
                bShipOBJ[1].GetComponent<BattleShip>().BSEnergy += level2EnergyUpgrade;
                break;
            case 3:
                bShipOBJ[1].GetComponent<BattleShip>().BSEnergy += level3EnergyUpgrade;
                break;
            case 4:
                bShipOBJ[1].GetComponent<BattleShip>().BSEnergy += level4EnergyUpgrade;
                break;
            default:
                print("ERROR!");
                break;
        }


        switch (BSUpgradeResource[2].energyLevel)
        {
            case 1:
                bShipOBJ[2].GetComponent<BattleShip>().BSEnergy += level1EnergyUpgrade;
                break;
            case 2:
                bShipOBJ[2].GetComponent<BattleShip>().BSEnergy += level2EnergyUpgrade;
                break;
            case 3:
                bShipOBJ[2].GetComponent<BattleShip>().BSEnergy += level3EnergyUpgrade;
                break;
            case 4:
                bShipOBJ[2].GetComponent<BattleShip>().BSEnergy += level4EnergyUpgrade;
                break;
            default:
                print("ERROR!");
                break;
        }

        switch (BSUpgradeResource[3].energyLevel)
        {
            case 1:
                bShipOBJ[3].GetComponent<BattleShip>().BSEnergy += level1EnergyUpgrade;
                break;
            case 2:
                bShipOBJ[3].GetComponent<BattleShip>().BSEnergy += level2EnergyUpgrade;
                break;
            case 3:
                bShipOBJ[3].GetComponent<BattleShip>().BSEnergy += level3EnergyUpgrade;
                break;
            case 4:
                bShipOBJ[3].GetComponent<BattleShip>().BSEnergy += level4EnergyUpgrade;
                break;
            default:
                print("ERROR!");
                break;
        }

        switch (BSUpgradeResource[4].energyLevel)
        {
            case 1:
                bShipOBJ[4].GetComponent<BattleShip>().BSEnergy += level1EnergyUpgrade;
                break;
            case 2:
                bShipOBJ[4].GetComponent<BattleShip>().BSEnergy += level2EnergyUpgrade;
                break;
            case 3:
                bShipOBJ[4].GetComponent<BattleShip>().BSEnergy += level3EnergyUpgrade;
                break;
            case 4:
                bShipOBJ[4].GetComponent<BattleShip>().BSEnergy += level4EnergyUpgrade;
                break;
            default:
                print("ERROR!");
                break;
        }

       
    }

    void ResourceFoodLevelUpgrade()
    {
        switch (BSUpgradeResource[0].foodLevel)
        {
            case 1:
                bShipOBJ[0].GetComponent<BattleShip>().BSFood += level1FoodUpgrade;
                break;
            case 2:
                bShipOBJ[0].GetComponent<BattleShip>().BSFood += level2FoodUpgrade;
                break;
            case 3:
                bShipOBJ[0].GetComponent<BattleShip>().BSFood += level3FoodUpgrade;
                break;
            case 4:
                bShipOBJ[0].GetComponent<BattleShip>().BSFood += level4FoodUpgrade;
                break;
            default:
                print("ERROR!");
                break;
        }

        switch (BSUpgradeResource[1].foodLevel)
        {
            case 1:
                bShipOBJ[1].GetComponent<BattleShip>().BSFood += level1FoodUpgrade;
                break;
            case 2:
                bShipOBJ[1].GetComponent<BattleShip>().BSFood += level2FoodUpgrade;
                break;
            case 3:
                bShipOBJ[1].GetComponent<BattleShip>().BSFood += level3FoodUpgrade;
                break;
            case 4:
                bShipOBJ[1].GetComponent<BattleShip>().BSFood += level4FoodUpgrade;
                break;
            default:
                print("ERROR!");
                break;
        }

        switch (BSUpgradeResource[2].foodLevel)
        {
            case 1:
                bShipOBJ[2].GetComponent<BattleShip>().BSFood += level1FoodUpgrade;
                break;
            case 2:
                bShipOBJ[2].GetComponent<BattleShip>().BSFood += level2FoodUpgrade;
                break;
            case 3:
                bShipOBJ[2].GetComponent<BattleShip>().BSFood += level3FoodUpgrade;
                break;
            case 4:
                bShipOBJ[2].GetComponent<BattleShip>().BSFood += level4FoodUpgrade;
                break;
            default:
                print("ERROR!");
                break;
        }


        switch (BSUpgradeResource[3].foodLevel)
        {
            case 1:
                bShipOBJ[3].GetComponent<BattleShip>().BSFood += level1FoodUpgrade;
                break;
            case 2:
                bShipOBJ[3].GetComponent<BattleShip>().BSFood += level2FoodUpgrade;
                break;
            case 3:
                bShipOBJ[3].GetComponent<BattleShip>().BSFood += level3FoodUpgrade;
                break;
            case 4:
                bShipOBJ[3].GetComponent<BattleShip>().BSFood += level4FoodUpgrade;
                break;
            default:
                print("ERROR!");
                break;
        }


        switch (BSUpgradeResource[4].foodLevel)
        {
            case 1:
                bShipOBJ[4].GetComponent<BattleShip>().BSFood += level1FoodUpgrade;
                break;
            case 2:
                bShipOBJ[4].GetComponent<BattleShip>().BSFood += level2FoodUpgrade;
                break;
            case 3:
                bShipOBJ[4].GetComponent<BattleShip>().BSFood += level3FoodUpgrade;
                break;
            case 4:
                bShipOBJ[4].GetComponent<BattleShip>().BSFood += level4FoodUpgrade;
                break;
            default:
                print("ERROR!");
                break;
        }
        
    }

    void ResourceAmmoLevelUpgrade()
    {
    }



}
