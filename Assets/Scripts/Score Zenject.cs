using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ScoreZenject : ITickable {

	Score score;
	Vector3 mousePositionZen;
	public ScoreZenject(Score score){

		this.score=score;

	} 
	public void Tick(){

		score.ScoreUpdate();
		
	 }

}
