/* Source File Name: GameController
 * Author's Name: Ibrahim Natchee and Mamun Rahman
 * Last Modified By: Ibrahim Natchee
 * Date Modified Last: December 5th 2016
 * Program Description: Controls player movement and mechanics
 * Revision History: December 5th 2016
 
 */

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerShooting : MonoBehaviour {

	// PUBLIC VARIABLES FOR TESTING
	public Transform FlashPoint;
	public GameObject MuzzleFlash;
	public GameObject Explosion;
	public GameObject BulletImpact;
	public AudioSource RifleShotSound;
	public Transform PlayerCam;

    // PRIVATE VARIABLES

        //testing
    /*private GameObject _gameControllerObject;
    private GameControllerScore _gameControllerScore;*/
    
    
    // Use this for initialization
    void Start () {


        //testing
       /* this._gameControllerObject = GameObject.Find("GameControllerScore");
        this._gameControllerScore = this._gameControllerObject.GetComponent<GameControllerScore>() as GameControllerScore;*/

    }
	
	// Update is called once per frame (for Physics)
	void FixedUpdate () {
		if (Input.GetButtonDown ("Fire1")) {
			// show the MuzzleFlash at the FlashPoint without any rotation
			Instantiate (this.MuzzleFlash, this.FlashPoint.position, Quaternion.identity);

			// need a variable to hold the location of our Raycast Hit
			RaycastHit hit;

			// if raycast hits an object then do something...
			if (Physics.Raycast (this.PlayerCam.position, this.PlayerCam.forward, out hit)) {

				if (hit.transform.gameObject.CompareTag ("Alien")) {
					Instantiate (this.Explosion, hit.point, Quaternion.identity);
                    //testing
                    //this._gameControllerScore.ScoreValue = this._gameControllerScore.ScoreValue + 10;
                    Destroy (hit.transform.gameObject);
				}
                 else if (hit.transform.gameObject.CompareTag("Troll"))
                {
                    Instantiate(this.Explosion, hit.point, Quaternion.identity);
                    //testing
                    //this._gameControllerScore.ScoreValue = this._gameControllerScore.ScoreValue + 10;
                    Destroy(hit.transform.gameObject);
                }


                else
                {
					Instantiate (this.BulletImpact, hit.point, Quaternion.identity);
				}


			}

			// Play Rifle Sound
			this.RifleShotSound.Play();
		}
	}


    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Exit")) { 
        SceneManager.LoadScene("SecondLevel");
        }
        //testing
       /* if (other.gameObject.CompareTag("Alien"))
        {
            this._gameControllerScore.LivesValue = this._gameControllerScore.LivesValue - 1;
        }
        if (other.gameObject.CompareTag("Tikki"))
        {
            this._gameControllerScore.ScoreValue = this._gameControllerScore.ScoreValue + 20;
        }*/
    }

   
}
