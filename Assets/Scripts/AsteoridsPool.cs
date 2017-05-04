using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteoridsPool  {
   
    readonly AsteroidsBehavoiur.Poolito asteroidPool;
    readonly List<AsteroidsBehavoiur> asteroidBehaviourList = new List<AsteroidsBehavoiur>();

   
    public AsteoridsPool(AsteroidsBehavoiur.Poolito bulletPool)
    {
        this.asteroidPool = bulletPool;
    }

    public void AddAsteroid(Vector2 spawn)
    {
        asteroidBehaviourList.Add(asteroidPool.Spawn(spawn));
        
    }

    public void RemoveAsteroid(AsteroidsBehavoiur asteroid)
    {   
       
      //  asteroid = asteroidBehaviourList[0];
        asteroidPool.Despawn(asteroid);
        asteroidBehaviourList.Remove(asteroid);
    }
}
