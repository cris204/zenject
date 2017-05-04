using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class AsteroidsBehavoiur : MonoBehaviour {

   private Rigidbody2D bulletRigidbody;
    Vector3 _velocity;
    
    private Vector2 initialPosition;  
    private Vector2 bulletVelocity;

    [Inject]
    private AsteroidsActive asteroidActive;

    private int contador;
	
  /*  [Inject]
    public void Construct()
    {
        Reset(Vector3.zero);
    }*/
    void Awake()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>(); 
        transform.position=RandomPosition();
    }
    
   private Vector2 RandomPosition(){
        initialPosition=new Vector2(Random.Range(-1.3f,1.3f),1.14f);  
        return initialPosition;
    }



    void Reset(Vector3 position)
    {
        transform.position = RandomPosition();
        _velocity = Vector3.zero;
    }


    void OnTriggerEnter2D(Collider2D other){

        if(other.gameObject.CompareTag("limit")){
        asteroidActive.asteroidPool.RemoveAsteroid(gameObject.GetComponent<AsteroidsBehavoiur>());
        }

        if(other.gameObject.CompareTag("player")){
           asteroidActive.asteroidPool.RemoveAsteroid(gameObject.GetComponent<AsteroidsBehavoiur>()); 
        }

    }


    public class Poolito : MonoMemoryPool<Vector3, AsteroidsBehavoiur>
    {
        protected override void Reinitialize(Vector3 velocity, AsteroidsBehavoiur asteroids)
        {
        
            asteroids.Reset(velocity);
            asteroids._velocity = velocity;
        }
    }
}
