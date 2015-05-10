using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TotalResources : MonoBehaviour
{

    public GameObject BattleShip1;


    //public GameObject BattleShip2;

    //public GameObject BattleShip3;


    public Text TotalFoodText;

    public Text TotalEnergyText;

    public Text TotalAmmoText;

    //public Text TotalWeaponsText;

    public Text totalText;




    // private GameObject BattleShip2;

    // Use this for initialization
    void Start()
    {
        BattleShip1 = GameObject.Find("Battle Ship 1");

       // BattleShip2 = GameObject.Find("Battle Ship 2");

        //BattleShip3 = GameObject.Find("Battle Ship 3");


    }

    // Update is called once per frame
    void Update()
    {
        //
        float BS1Food = BattleShip1.GetComponent<BattleShipTEST>().BSFood;

        //float BS2Food = BattleShip2.GetComponent<BattleShipTEST>().BSFood;

        //float BS3Food = BattleShip3.GetComponent<BattleShipTEST>().BSFood;


        float totalFood = BS1Food;// +BS2Food + BS3Food;

        TotalFoodText.text = "Food " + totalFood;
        //

        //
        float BS1Energy = BattleShip1.GetComponent<BattleShipTEST>().BSEnergy;

       // float BS2Energy = BattleShip2.GetComponent<BattleShipTEST>().BSEnergy;

        //float BS3Energy = BattleShip3.GetComponent<BattleShipTEST>().BSEnergy;


        float totalEnergy = BS1Energy;// +BS2Energy + BS3Energy;

        TotalEnergyText.text = "Energy " + totalEnergy;
        //

        //
        float BS1Ammo = BattleShip1.GetComponent<BattleShipTEST>().BSAmmo;

       // float BS2Ammo = BattleShip2.GetComponent<BattleShipTEST>().BSAmmo;

       // float BS3Ammo = BattleShip3.GetComponent<BattleShipTEST>().BSAmmo;


        float totalAmmo = BS1Ammo;// +BS2Ammo + BS3Ammo;

        TotalAmmoText.text = "Ammo " + totalAmmo;
        //

        //
        float totalAmmount = totalFood + totalEnergy + totalAmmo;

        totalText.text = "Total: " + totalAmmount;

    }
}
