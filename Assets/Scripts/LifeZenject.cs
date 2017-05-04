using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;
public class LifeZenject : ITickable {

	
	Life life;

		public LifeZenject(Life life){

		this.life=life;

	}
	public void Tick(){
		life.HealthBar();
		if(life.health<=0){
			SceneManager.LoadScene(0);
			Score.score=0;
		}
	}
}
