using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TotalResources : MonoBehaviour
{

    public BattleShip[] BattleShips;

    private GameObject[] bShipOBJ;

    public MotherShip MSScript;




    public Text TotalFoodText;

    public Text TotalEnergyText;

    public Text TotalAmmoText;

    //public Text TotalWeaponsText;

    public Text totalText;


    


    public int totalEnergy;

    public int totalFood;

    public int totalAmmo;


    // private GameObject BattleShip2;

    // Use this for initialization
    void Start()
    {

        MSScript = GameObject.Find("MotherShip").GetComponent<MotherShip>();


        bShipOBJ = GameObject.FindGameObjectsWithTag("Battle Ship");


        for (int i = 0; i < bShipOBJ.Length; i++)
        {
            BattleShips[i] = bShipOBJ[i].GetComponent<BattleShip>();

        }


    }

    // Update is called once per frame
    void Update()
    {

        //
        int MSEnergy = MSScript.MSEnergy;

        for (int i = 0; i < BattleShips.Length; i++)
        {
            int S1Energy = BattleShips[0].BSEnergy;

            int S2Energy = BattleShips[1].BSEnergy;

            int S3Energy = BattleShips[2].BSEnergy;

            int S4Energy = BattleShips[3].BSEnergy;

            int S5Energy = BattleShips[4].BSEnergy;

            totalEnergy = S1Energy + S2Energy + S3Energy + S4Energy + S5Energy + MSEnergy;
        }

        TotalEnergyText.text = "Energy " + totalEnergy;
        //


        //
        int MSFood = MSScript.MSFood;

        for (int i = 0; i < BattleShips.Length; i++)
        {
            int S1Food = BattleShips[0].BSFood;

            int S2Food = BattleShips[1].BSFood;

            int S3Food = BattleShips[2].BSFood;

            int S4Food = BattleShips[3].BSFood;

            int S5Food = BattleShips[4].BSFood;

            totalFood = S1Food + S2Food + S3Food + S4Food + S5Food + MSFood;

        }

       // print(MSFood);

        TotalFoodText.text = "Food " + totalFood;
        //

        //
        int MSAmmo = MSScript.MSAmmo;



        totalAmmo = MSAmmo;// +BS1Ammo;// +BS2Ammo + BS3Ammo;

        TotalAmmoText.text = "Ammo " + totalAmmo;
        //


        //
        int totalAmmount = totalFood + totalEnergy + totalAmmo;


        if (totalEnergy <= 0)
        {
            Debug.Log("GAME OVER");
        }

        totalText.text = "Total: " + totalAmmount;

    }
}
