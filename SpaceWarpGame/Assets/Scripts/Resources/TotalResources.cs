using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TotalResources : MonoBehaviour
{

    public BattleShipTEST BattleShip1;

    public MotherShipTest MSScript;


    public Text TotalFoodText;

    public Text TotalEnergyText;

    public Text TotalAmmoText;

    //public Text TotalWeaponsText;

    public Text totalText;


    //public int totalEnergy;

    //public int totalFood;

    //public int totalAmmo;


    // private GameObject BattleShip2;

    // Use this for initialization
    void Start()
    {

        MSScript = GameObject.Find("MotherShip").GetComponent<MotherShipTest>();

        BattleShip1 = GameObject.Find("Battle Ship 1").GetComponent<BattleShipTEST>();



       // BattleShip2 = GameObject.Find("Battle Ship 2");

        //BattleShip3 = GameObject.Find("Battle Ship 3");


    }

    // Update is called once per frame
    void Update()
    {

        //
        int MSEnergy = MSScript.MSEnergy;

        int BS1Energy = BattleShip1.GetComponent<BattleShipTEST>().BSEnergy;

        // float BS2Energy = BattleShip2.GetComponent<BattleShipTEST>().BSEnergy;

        //float BS3Energy = BattleShip3.GetComponent<BattleShipTEST>().BSEnergy;


        int totalEnergy = MSEnergy + BS1Energy;// +BS2Energy + BS3Energy;

        TotalEnergyText.text = "Energy " + totalEnergy;
        //


        //
        int MSFood = MSScript.MSFood;

        int BS1Food = BattleShip1.GetComponent<BattleShipTEST>().BSFood;

        //float BS2Food = BattleShip2.GetComponent<BattleShipTEST>().BSFood;

        //float BS3Food = BattleShip3.GetComponent<BattleShipTEST>().BSFood;


       int totalFood = MSFood + BS1Food;// +BS2Food + BS3Food;

        TotalFoodText.text = "Food " + totalFood;
        //

       

        //
        int MSAmmo = MSScript.MSAmmo;

        int BS1Ammo = BattleShip1.GetComponent<BattleShipTEST>().BSAmmo;

       // float BS2Ammo = BattleShip2.GetComponent<BattleShipTEST>().BSAmmo;

       // float BS3Ammo = BattleShip3.GetComponent<BattleShipTEST>().BSAmmo;


       int totalAmmo = MSAmmo + BS1Ammo;// +BS2Ammo + BS3Ammo;

        TotalAmmoText.text = "Ammo " + totalAmmo;
        //

        //
        int totalAmmount = totalFood + totalEnergy + totalAmmo;

        if (totalAmmount <= 0)
        {
            Debug.Log("GAME OVER");
        }

        totalText.text = "Total: " + totalAmmount;

    }
}
