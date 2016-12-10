/* Source File Name: GameController
 * Author's Name: Ibrahim Natchee and Mamun Rahman
 * Last Modified By: Ibrahim Natchee
 * Date Modified Last: December 5th 2016
 * Program Description: To create and control UI
 * Revision History: December 5th 2016
 
 */

using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES
	public UnityEngine.AI.NavMeshAgent Agent;

	// PRIVATE INSTANCE VARIABLES
	private Transform Player;

	// Use this for initialization
	void Start () {
		this.Player = GameObject.FindWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		this.Agent.SetDestination (this.Player.position);
	}
}
