using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	Rigidbody2D rb;

	[SerializeField]
	float speed;


	public void Move(Vector2 direccion){

		rb.velocity=direccion*speed;
	}
}
