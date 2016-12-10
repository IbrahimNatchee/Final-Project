/* Source File Name: GameController
 * Author's Name: Ibrahim Natchee and Mamun Rahman
 * Last Modified By: Ibrahim Natchee
 * Date Modified Last: December 5th 2016
 * Program Description: this file is going to describe how the tikki item is going to effect the score, how it moves and what it does
 * Revision History: December 5th 2016
 */



using UnityEngine;
using System.Collections;

public class TikkiController : MonoBehaviour {

    public AudioSource TikkiSound;

    //it will wait 0.7 seconds before playing
    private WaitForSeconds waitTime = new WaitForSeconds (0.7f);




    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
           
        
    }

    //ibncase player goes through the Tikki what would happen? we gotta tell the game
    void OnTriggerEnter(Collider other){

if (other.gameObject.CompareTag ("Player")) {
            //cant put sound inittiation and destory here because it
            //destroys the coin before the sound emmits so we gotta use a CoRoutine
            //so we use this method to play our Coroutine method
            StartCoroutine (PlaySoundAndDestroy());


            //whats Coroutine? its Concurrency, creating a secondary thread to control the coroutine in and that we can control
            //the timing of that thread through the "Yield" key word which we use to tell us how long we have to
            // wait before it 'yields' control back to the main thread
        }
    }

    //this is the routine that will help us play the sound once we pass by our Tikki, works sorta like a function.
    //this is our CoRoutine
    IEnumerator PlaySoundAndDestroy() {
        TikkiSound.Play();
        //return everything after 0.1 second then we initiate destory
        yield return this.waitTime;
        //initiate destroy
        Destroy(this.gameObject);
    }
}
