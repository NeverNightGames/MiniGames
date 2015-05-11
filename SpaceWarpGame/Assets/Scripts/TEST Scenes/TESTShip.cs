using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TESTShip : MonoBehaviour {

    public int SEnergy;

    public bool Updated;

	// Use this for initialization
	void Start () 
    {
       // GetComponent<Text>().text = "" + SEnergy;
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        GetComponent<Text>().text = "" + SEnergy;
	
	}

    public void MyClick()
    {
        //SEnergy += 50;

        Updated = true;

        
    }

    public void MyClick1()
    {
        SEnergy -= 1;
    }



}
