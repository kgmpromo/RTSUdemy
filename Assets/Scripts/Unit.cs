using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Unit : MonoBehaviour
{

	const string ANIMATOR_SPEED = "Speed", ANIMATOR_ALIVE = "ALive", ANIMATOR_ATTACK = "Attack";
	public Transform target;
	Animator animator;
	NavMeshAgent nav;


	private void Awake()
	{
		nav = GetComponent<NavMeshAgent>();
		animator = GetComponent<Animator>();

	}

	void Update()
	{
		if (target)
		{
			nav.SetDestination(target.position);
		}
		Animate();


	}

	protected virtual void Animate()
	{
		var SpeedVector = nav.velocity;
		SpeedVector.y = 0;

		float speed = SpeedVector.magnitude;
		animator.SetFloat(ANIMATOR_SPEED, speed);
	}

}
