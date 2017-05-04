using UnityEngine;
using Zenject;
public class BulletBehaviour : MonoBehaviour
{   

    
   private GameObject empty;
    private Rigidbody2D bulletRigidbody;
    Vector3 _velocity;
    
    private Vector2 bulletVelocity;

    private int contador;


    [Inject]
    private Fire fire;

     [Inject]
    private AsteroidsActive asteroidActive;

  /*  [Inject]
    public BulletBehaviour ()
    {
        Reset(empty);
    }*/
    void Awake()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();   
        
        empty=this.gameObject;
    }
        
  /*  void Update()
    {   
     if(Input.GetMouseButton(0) && contador <1){
        bulletRigidbody.velocity = velocity();
        contador++;
     }
    }

    private Vector2 velocity(){
        
        bulletVelocity=(Camera.main.ScreenToWorldPoint (Input.mousePosition)-transform.position).normalized*2;

        if(bulletVelocity.magnitude<0.2f){

            bulletVelocity= bulletVelocity*20;
          
        }

        return bulletVelocity;
    }*/

    void Reset( GameObject cannon)
    {
        transform.position = cannon.transform.position;
        
        _velocity = Vector3.zero;
        bulletRigidbody.velocity=cannon.transform.forward*5;
    }

    
     void OnTriggerEnter2D (Collider2D other){

         	if(other.gameObject.CompareTag("asteroids"))
             {

                Score.score+=20;
                fire.bulletPool.RemoveBullet(GetComponent<BulletBehaviour>());
                asteroidActive.asteroidPool.RemoveAsteroid(other.gameObject.GetComponent<AsteroidsBehavoiur>());
		    }
            	if(other.gameObject.CompareTag("limit"))
             {
                 fire.bulletPool.RemoveBullet(GetComponent<BulletBehaviour>());
             }
            
    }

    public class Pool : MonoMemoryPool<GameObject, BulletBehaviour>
    {
        protected override void Reinitialize(GameObject cannon, BulletBehaviour bullet)
        {
        
            bullet.Reset(cannon);
            bullet._velocity = cannon.transform.position;
        }
    }
}