using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Cycle : MonoBehaviour
{

    public float timer;

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


    public int foodRemoval;

    public int level1FoodUpgrade;

    public int level2FoodUpgrade;

    public int level3FoodUpgrade;

    public int level4FoodUpgrade;


    public int Level1AmmoUpgrade;

    public int Level2AmmoUpgrade;

    public int Level3AmmoUpgrade;

    public int Level4AmmoUpgrade;


    // Use this for initialization
    void Start()
    {
        MSScript = GameObject.Find("MotherShip").GetComponent<MotherShip>();

        // totResources = this.gameObject.GetComponentInParent<TotalResources>();

        bShipOBJ = GameObject.FindGameObjectsWithTag("Battle Ship");

        for (int i = 0; i < bShipOBJ.Length; i++)
        {
            BSUpgradeResource[i] = bShipOBJ[i].GetComponent<UpgradeResource>();
        }

    }

    // Update is called once per frame
    void Update()
    {

        totResources = this.gameObject.GetComponentInParent<TotalResources>();


        timer += Time.fixedDeltaTime;

        //Cycle
        if (timer >= cycleTime)
        {
            


            ResourceEnergyLevelUpgrade();

            ResourceFoodLevelUpgrade();

            ResourceAmmoLevelUpgrade();


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
                bShipOBJ[0].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            case 2:
                bShipOBJ[0].GetComponent<BattleShip>().BSFood += level2FoodUpgrade;
                bShipOBJ[0].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            case 3:
                bShipOBJ[0].GetComponent<BattleShip>().BSFood += level3FoodUpgrade;
                bShipOBJ[0].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            case 4:
                bShipOBJ[0].GetComponent<BattleShip>().BSFood += level4FoodUpgrade;
                bShipOBJ[0].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            default:
                print("ERROR!");
                break;
        }

        switch (BSUpgradeResource[1].foodLevel)
        {
            case 1:
                bShipOBJ[1].GetComponent<BattleShip>().BSFood += level1FoodUpgrade;
                bShipOBJ[1].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            case 2:
                bShipOBJ[1].GetComponent<BattleShip>().BSFood += level2FoodUpgrade;
                bShipOBJ[1].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            case 3:
                bShipOBJ[1].GetComponent<BattleShip>().BSFood += level3FoodUpgrade;
                bShipOBJ[1].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            case 4:
                bShipOBJ[1].GetComponent<BattleShip>().BSFood += level4FoodUpgrade;
                bShipOBJ[1].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            default:
                print("ERROR!");
                break;
        }

        switch (BSUpgradeResource[2].foodLevel)
        {
            case 1:
                bShipOBJ[2].GetComponent<BattleShip>().BSFood += level1FoodUpgrade;
                bShipOBJ[2].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            case 2:
                bShipOBJ[2].GetComponent<BattleShip>().BSFood += level2FoodUpgrade;
                bShipOBJ[2].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            case 3:
                bShipOBJ[2].GetComponent<BattleShip>().BSFood += level3FoodUpgrade;
                bShipOBJ[2].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            case 4:
                bShipOBJ[2].GetComponent<BattleShip>().BSFood += level4FoodUpgrade;
                bShipOBJ[2].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            default:
                print("ERROR!");
                break;
        }


        switch (BSUpgradeResource[3].foodLevel)
        {
            case 1:
                bShipOBJ[3].GetComponent<BattleShip>().BSFood += level1FoodUpgrade;
                bShipOBJ[3].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            case 2:
                bShipOBJ[3].GetComponent<BattleShip>().BSFood += level2FoodUpgrade;
                bShipOBJ[3].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            case 3:
                bShipOBJ[3].GetComponent<BattleShip>().BSFood += level3FoodUpgrade;
                bShipOBJ[3].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            case 4:
                bShipOBJ[3].GetComponent<BattleShip>().BSFood += level4FoodUpgrade;
                bShipOBJ[3].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            default:
                print("ERROR!");
                break;
        }


        switch (BSUpgradeResource[4].foodLevel)
        {
            case 1:
                bShipOBJ[4].GetComponent<BattleShip>().BSFood += level1FoodUpgrade;
                bShipOBJ[4].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            case 2:
                bShipOBJ[4].GetComponent<BattleShip>().BSFood += level2FoodUpgrade;
                bShipOBJ[4].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            case 3:
                bShipOBJ[4].GetComponent<BattleShip>().BSFood += level3FoodUpgrade;
                bShipOBJ[4].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            case 4:
                bShipOBJ[4].GetComponent<BattleShip>().BSFood += level4FoodUpgrade;
                bShipOBJ[4].GetComponent<BattleShip>().BSFood -= foodRemoval;
                break;
            default:
                print("ERROR!");
                break;
        }

    }

    void ResourceAmmoLevelUpgrade()
    {
        switch (BSUpgradeResource[0].ammoLevel)
        {
            case 1:
                MSScript.MSAmmo += Level1AmmoUpgrade;
                break;
            case 2:
                MSScript.MSAmmo += Level2AmmoUpgrade;
                // bShipOBJ[0].GetComponent<BattleShip>().BSAmmo += Level2AmmoUpgrade;
                break;
            case 3:
                MSScript.MSAmmo += Level3AmmoUpgrade;
                break;
            case 4:
                MSScript.MSAmmo += Level4AmmoUpgrade;
                break;
            default:
                print("ERROR");
                break;
        }

        switch (BSUpgradeResource[1].ammoLevel)
        {
            case 1:
                MSScript.MSAmmo += Level1AmmoUpgrade;
                break;
            case 2:
                MSScript.MSAmmo += Level2AmmoUpgrade;
                break;
            case 3:
                MSScript.MSAmmo += Level3AmmoUpgrade;
                break;
            case 4:
                MSScript.MSAmmo += Level4AmmoUpgrade;
                break;
            default:
                print("ERROR");
                break;
        }

        switch (BSUpgradeResource[2].ammoLevel)
        {
            case 1:
                MSScript.MSAmmo += Level1AmmoUpgrade;
                break;
            case 2:
                MSScript.MSAmmo += Level2AmmoUpgrade;
                break;
            case 3:
                MSScript.MSAmmo += Level3AmmoUpgrade;
                break;
            case 4:
                MSScript.MSAmmo += Level4AmmoUpgrade;
                break;
            default:
                print("ERROR");
                break;
        }

        switch (BSUpgradeResource[3].ammoLevel)
        {
            case 1:
                MSScript.MSAmmo += Level1AmmoUpgrade;
                break;
            case 2:
                MSScript.MSAmmo += Level2AmmoUpgrade;
                break;
            case 3:
                MSScript.MSAmmo += Level3AmmoUpgrade;
                break;
            case 4:
                MSScript.MSAmmo += Level4AmmoUpgrade;
                break;
            default:
                print("ERROR");
                break;
        }

        switch (BSUpgradeResource[4].ammoLevel)
        {
            case 1:
                MSScript.MSAmmo += Level1AmmoUpgrade;
                break;
            case 2:
                MSScript.MSAmmo += Level2AmmoUpgrade;
                break;
            case 3:
                MSScript.MSAmmo += Level3AmmoUpgrade;
                break;
            case 4:
                MSScript.MSAmmo += Level4AmmoUpgrade;
                break;
            default:
                print("ERROR");
                break;
        }


    }



}
