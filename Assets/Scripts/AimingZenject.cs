using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class AimingZenject : ITickable {

	Aiming aim;
	Vector3 mousePositionZen;
	public AimingZenject(Aiming aim){

		this.aim=aim;

	}
	public void Tick(){
		mousePositionZen = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		aim.GetMouseAiming(mousePositionZen);
	}
}
