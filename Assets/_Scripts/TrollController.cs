using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrollController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public UnityEngine.AI.NavMeshAgent Agent;
	public int AnimateState;

	// PRIVATE INSTANCE VARIABLES
	private Transform Player;
	private Animator _animator;
	private Animation _animation;
	private AnimationState state;
	private GameObject _gameControllerObject;
	private GameControllerScore _gameControllerScore;
	private int _lifeTimeCount;
	// Use this for initialization
	void Start () {
		this.Player = GameObject.FindWithTag ("Player").transform;
		this._animator = GetComponent<Animator> ();
		this._animation = GetComponent<Animation> ();
		this.AnimateState = 0;
		this._lifeTimeCount = 0;
		this._animation.Play("Walk");

		this._gameControllerObject = GameObject.Find("GameControllerScore");
		this._gameControllerScore = this._gameControllerObject.GetComponent<GameControllerScore>() as GameControllerScore;

	}

	// Update is called once per frame
	void Update () {
		this.Agent.SetDestination (this.Player.position);


		if (this.AnimateState == 0 && this._animation.isPlaying==false) {
			this._animation.Play("Walk");
		}
			
	}
	void FixedUpdate () {

		if (this.AnimateState == 1) {
			this._animation["Hit"].wrapMode = WrapMode.Once;

			this._animation.Play("Hit");

			this.AnimateState = 0;

		}
		if (this.Agent.remainingDistance != 0) {
			if (this.Agent.remainingDistance < 12 ) {

				this._animation ["Attack_01"].wrapMode = WrapMode.Once;

				this._animation.Play ("Attack_01");
				if (this._animation.Play ("Attack_01")) {
					this._lifeTimeCount++;
					if (this._lifeTimeCount > 60) {
						this._gameControllerScore.LivesValue = this._gameControllerScore.LivesValue - 1;
						this._lifeTimeCount = 0;
					}
				}


					
	
			}
		}



	}

}
