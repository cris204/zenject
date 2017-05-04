using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerControllerZenject : ITickable {

	float horizontal,vertical;
	Vector2 direccion;
	PlayerController controller;
	public PlayerControllerZenject(PlayerController controller){

		this.controller=controller;

	}

	public void Tick(){

		horizontal=Input.GetAxis("Horizontal");
		vertical=Input.GetAxis("Vertical");

		direccion=new Vector2(horizontal,vertical);


		controller.Move(direccion);

	}

}
