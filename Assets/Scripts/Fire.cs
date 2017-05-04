using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Fire : MonoBehaviour {

	[Inject]
	public BulletPool bulletPool;


	[SerializeField]
	private GameObject cannon;
	void Update () {
		
		if(Input.GetMouseButtonDown(0)){
			bulletPool.AddBullet(cannon);
			
			
		//	Debug.Break();
		}

	} 
}
