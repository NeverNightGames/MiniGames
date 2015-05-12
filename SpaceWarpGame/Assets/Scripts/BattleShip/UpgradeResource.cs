using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpgradeResource : MonoBehaviour
{

    public int upgradeCost1 = 250;

    public int upgradeCost2 = 500;

    public int upgradeCost3 = 750;

    public int upgradeCost4 = 1000;


    public int energyLevel;

    public int foodLevel;

    public int ammoLevel;

    public int weaponsLevel;


    //public bool updatedEnergy;

    //public bool updatedFood;

    //public bool updatedAmmo;

    //public bool updatedWeapons;


    public Text energyCostText;

    public Text foodCostText;

    public Text ammoCostText;

    public Text weaponCostText;


    public Text energyLevelText;

    public Text foodLevelText;

    public Text ammoLevelText;

    public Text weaponsLevelText;


    public BattleShipTEST BShip;


    // Use this for initialization
    void Start()
    {
        BShip = GameObject.Find("Battle Ship 1").GetComponent<BattleShipTEST>();
    }

    // Update is called once per frame
    void Update()
    {
        // Cost text
        switch (energyLevel)
        {
            case 1:
                energyCostText.text = "Cost: " + upgradeCost1;
                break;
            case 2:
                energyCostText.text = "Cost: " + upgradeCost2;
                break;
            case 3:
                energyCostText.text = "Cost: " + upgradeCost3;
                break;
            case 4:
                energyCostText.text = "Cost: " + upgradeCost4;
                break;
            default:
                print("ERROR");
                break;

        }

        switch (foodLevel)
        {
            case 1:
                foodCostText.text = "Cost: " + upgradeCost1;
                break;
            case 2:
                foodCostText.text = "Cost: " + upgradeCost2;
                break;
            case 3:
                foodCostText.text = "Cost: " + upgradeCost3;
                break;
            case 4:
                foodCostText.text = "Cost: " + upgradeCost4;
                break;
            default:
                print("ERROR");
                break;

        }

        switch (ammoLevel)
        {
            case 1:
                ammoCostText.text = "Cost " + upgradeCost1;
                break;
            case 2:
                ammoCostText.text = "Cost " + upgradeCost2;
                break;
            case 3:
                ammoCostText.text = "Cost " + upgradeCost3;
                break;
            case 4:
                ammoCostText.text = "Cost " + upgradeCost4;
                break;
            default:
                print("ERROR");
                break;

        }

        switch (weaponsLevel)
        {
            case 1:
                weaponCostText.text = "Cost " + upgradeCost1;
                break;
            case 2:
                weaponCostText.text = "Cost " + upgradeCost2;
                break;
            case 3:
                weaponCostText.text = "Cost " + upgradeCost3;
                break;
            case 4:
                weaponCostText.text = "Cost " + upgradeCost4;
                break;
            default:
                print("ERROR");
                break;

        }
        //

        // Levels text
        energyLevelText.text = "Energy: " + energyLevel;

        foodLevelText.text = "Food: " + foodLevel;

        ammoLevelText.text = "Ammo " + ammoLevel;

        weaponsLevelText.text = "Weapons: " + weaponsLevel;
        //




    }

    public void EnergyUpgrade()
    {

        switch (energyLevel)
        {
            case 1:
                BShip.BSEnergy -= upgradeCost1;
                break;
            case 2:
                BShip.BSEnergy -= upgradeCost2;
                break;
            case 3:
                BShip.BSEnergy -= upgradeCost3;
                break;
            case 4:
                BShip.BSEnergy -= upgradeCost4;
                break;
            default:
                print("ERROR");
                break;
        }

   

        energyLevel += 1;


    }

    public void FoodUpgrade()
    {
        switch (foodLevel)
        {
            case 1:
                BShip.BSEnergy -= upgradeCost1;
                break;
            case 2:
                BShip.BSEnergy -= upgradeCost2;
                break;
            case 3:
                BShip.BSEnergy -= upgradeCost3;
                break;
            case 4:
                BShip.BSEnergy -= upgradeCost4;
                break;
            default:
                print("ERROR");
                break;
        }


        foodLevel += 1;
    }

    public void AmmoUpgrade()
    {
        // BSAmmo += 15;

        // updatedAmmo = true;

       // BShip.BSEnergy -= upgradeCost1;

        switch (ammoLevel)
        {
            case 1:
                BShip.BSEnergy -= upgradeCost1;
                break;
            case 2:
                BShip.BSEnergy -= upgradeCost2;
                break;
            case 3:
                BShip.BSEnergy -= upgradeCost3;
                break;
            case 4:
                BShip.BSEnergy -= upgradeCost4;
                break;
            default:
                print("ERROR");
                break;
        }


        ammoLevel += 1;
    }

    public void WeaponsUpgrade()
    {
        switch (weaponsLevel)
        {
            case 1:
                BShip.BSEnergy -= upgradeCost1;
                break;
            case 2:
                BShip.BSEnergy -= upgradeCost2;
                break;
            case 3:
                BShip.BSEnergy -= upgradeCost3;
                break;
            case 4:
                BShip.BSEnergy -= upgradeCost4;
                break;
            default:
                print("ERROR");
                break;
        }


        weaponsLevel += 1;

        //BShip.BSEnergy -= upgradeCost1;

        //print("Weapons");
    }


}
