using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour {

	[SerializeField]
	private Image healthImage;

	public float health=100;
	public void HealthBar(){
		healthImage.fillAmount=health/100;
	}
	
	void OnTriggerEnter2D(Collider2D other){

		if(other.gameObject.CompareTag("asteroids")){

			health-=20;

		}

	}



}
