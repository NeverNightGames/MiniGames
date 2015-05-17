using UnityEngine;
using System.Collections;

public class MusicChange : MonoBehaviour {

    public AudioClip calmMusic;

    public AudioClip battleMusic;

    private AudioSource ASource;

    public ShipTurret bsShipTur;

	// Use this for initialization
	void Start () 
    {
       

        //eWave = GameObject.Find("Game Master").GetComponent<EnemyWave>();

        bsShipTur = GameObject.FindGameObjectWithTag("Battle Ship").GetComponentInChildren<ShipTurret>();

        
	
	}

	
	// Update is called once per frame
	void Update () 
    {
       // ASource = this.gameObject.GetComponent<AudioSource>();

        if (bsShipTur.playBattleMusic == true)
        {
            StartA(battleMusic);
        }
        else
        {
            StartA(calmMusic);
        }

        //ASource.Play();
       
	
	}

    IEnumerator StartA(AudioClip AC)
    {
        ASource = this.gameObject.GetComponent<AudioSource>();

        ASource.clip = AC;

        ASource.Play();

        yield return new WaitForSeconds(ASource.clip.length);

        //ASource.clip = AC;

        ASource.Play();
    }
}
