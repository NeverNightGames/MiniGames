using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpgradeResource : MonoBehaviour
{

    public int upgradeCost1;

    public int upgradeCost2;

    public int upgradeCost3;

    public int upgradeCost4;


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


    public BattleShip BShip;


    private bool canUpgradeEnergy = true;

    private bool canUpgradeFood = true;

    private bool canUpgradeAmmo = true;

    private bool canUpgradeWeapons = true;

    public TotalResources totResource;

    // Use this for initialization
    void Start()
    {
        BShip = GameObject.Find("Battle Ship 1").GetComponent<BattleShip>();

        totResource = GameObject.Find("Game Master").GetComponent<TotalResources>();
    }

    // Update is called once per frame
    void Update()
    {

        //upgradeCost1 = 13 + energyLevel + (2 * foodLevel + 2 * ammoLevel + 2 * weaponsLevel);

        //upgradeCost2 = 13 + energyLevel + (2 * foodLevel + 2 * ammoLevel + 2 * weaponsLevel);

        //upgradeCost3 = 13 + energyLevel + (2 * foodLevel + 2 * ammoLevel + 2 * weaponsLevel);

        //upgradeCost4 = 13 + energyLevel + (2 * foodLevel + 2 * ammoLevel + 2 * weaponsLevel);



        // Cost text
        switch (energyLevel)
        {
            case 1:
                energyCostText.text = "     " + upgradeCost1;
                break;
            case 2:
                energyCostText.text = "     " + upgradeCost2;
                break;
            case 3:
                energyCostText.text = "     " + upgradeCost3;
                break;
            case 4:
                energyCostText.text = "     " + upgradeCost4;
                canUpgradeEnergy = false;
                break;
            default:
                print("ERROR");
                break;

        }

        switch (foodLevel)
        {
                
            case 1:
                foodCostText.text = "     " + upgradeCost1;
                break;
            case 2:
                foodCostText.text = "     " + upgradeCost2;
                break;
            case 3:
                foodCostText.text = "     " + upgradeCost3;
                break;
            case 4:
                foodCostText.text = "     " + upgradeCost4;
                canUpgradeFood = false;
                break;
            default:
                print("ERROR");
                break;

        }

        switch (ammoLevel)
        {
            case 1:
                ammoCostText.text = "     " + upgradeCost1;
                break;
            case 2:
                ammoCostText.text = "     " + upgradeCost2;
                totResource.totalAmmo += 50;
                break;
            case 3:
                ammoCostText.text = "     " + upgradeCost3;
                totResource.totalAmmo += 75;
                break;
            case 4:
                ammoCostText.text = "     " + upgradeCost4;
                totResource.totalAmmo += 100;
                canUpgradeAmmo = false;
                break;
            default:
                print("ERROR");
                break;

        }

      

        switch (weaponsLevel)
        {
            case 1:
                weaponCostText.text = "     " + 500;
                break;
            //case 2:
            //    weaponCostText.text = "     " + upgradeCost2;
            //    break;
            //case 3:
            //    weaponCostText.text = "     " + upgradeCost3;
            //    break;
            //case 4:
            //    weaponCostText.text = "     " + upgradeCost4;
            //   canUpgradeWeapons = false;
            //    break;
            default:
                print("ERROR");
                break;

        }
        //

        // Levels text
        energyLevelText.text = "                       " + energyLevel;

        foodLevelText.text = "                       " + foodLevel;

        ammoLevelText.text = "                       " + ammoLevel;

        weaponsLevelText.text = "                       " + weaponsLevel;
        //




    }

    public void EnergyUpgrade()
    {

        if (canUpgradeEnergy == true)
        {
            if (totResource.totalEnergy >= 100)
            {

                energyLevel += 1;

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
                        canUpgradeEnergy = false;
                        break;
                    default:
                        print("ERROR");
                        break;
                }
            }
        }

   

        


    }

    public void FoodUpgrade()
    {
        

        if (canUpgradeFood == true)
        {
            if (totResource.totalEnergy >= 100)
            {

                foodLevel += 1;




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
                        canUpgradeFood = false;
                        break;
                    default:
                        print("ERROR");
                        break;
                }
            }
        }


       
    }

    public void AmmoUpgrade()
    {
        if (canUpgradeAmmo == true)
        {


            if (totResource.totalEnergy >= 100)
            {
                ammoLevel += 1;


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
                        canUpgradeAmmo = false;
                        break;
                    default:
                        print("ERROR");
                        break;
                }
            }
        }


        
    }

    public void WeaponsUpgrade()
    {
        if (canUpgradeWeapons == true)
        {

            weaponsLevel += 1;

            switch (weaponsLevel)
            {
                case 1:
                    BShip.BSEnergy -= 500;
                    break;
                default:
                    print("ERROR");
                    break;
            }
        }


        

        //BShip.BSEnergy -= upgradeCost1;

        //print("Weapons");
    }


}
