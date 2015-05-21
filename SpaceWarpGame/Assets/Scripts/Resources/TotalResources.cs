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



    int S1Food;

    int S2Food;

    int S3Food;

    int S4Food;

    int S5Food;



    public int totalEnergy;

    public int totalFood;

    public int totalAmmo;


    Cycle Cyc;


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
        Cyc = this.gameObject.GetComponent<Cycle>();

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
            S1Food = BattleShips[0].BSFood;

            S2Food = BattleShips[1].BSFood;

            S3Food = BattleShips[2].BSFood;

            S4Food = BattleShips[3].BSFood;

            S5Food = BattleShips[4].BSFood;


        }

        totalFood = S1Food + S2Food + S3Food + S4Food + S5Food + MSFood;

        //if (Cyc.timer >= Cyc.cycleTime)
        //{
        //    totalFood -= 500;
        //}


        TotalFoodText.text = "Food " + totalFood;


        //TotalFoodText.text = "Food " + totalFood;
        //

        //
        int MSAmmo = MSScript.MSAmmo;

        for (int i = 0; i < BattleShips.Length; i++)
        {
            int S1Ammo = BattleShips[0].BSAmmo;

            int S2Ammo = BattleShips[1].BSAmmo;

            int S3Ammo = BattleShips[2].BSAmmo;

            int S4Ammo = BattleShips[3].BSAmmo;

            int S5Ammo = BattleShips[4].BSAmmo;

            totalAmmo = S1Ammo + S2Ammo + S3Ammo + S4Ammo + S5Ammo + MSAmmo;

        }

        TotalAmmoText.text = "Ammo " + totalAmmo;
        //


        //
        int totalAmmount = totalFood + totalEnergy + totalAmmo;


      


        //if (totalEnergy <= 0)
        //{
        //    Debug.Log("GAME OVER");
        //}

        totalText.text = "Total: " + totalAmmount;

    }
}
