using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class AsteroidsActive : MonoBehaviour {

	[Inject]
	public AsteoridsPool asteroidPool;

	private Vector2 initialPotition;
	private float time;
	// Update is called once per frame
	void Update () {
		
		time+=Time.deltaTime;
		if(time>0.5f){
			asteroidPool.AddAsteroid( new Vector2(Random.Range(-1.3f,1.3f),1.14f));
			time=0;
		}		

	}
}
