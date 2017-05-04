using System.Collections.Generic;
using System;
using UnityEngine;
public class BulletPool
{
    readonly BulletBehaviour.Pool bulletPool;
    readonly List<BulletBehaviour> bulletBehaviourList = new List<BulletBehaviour>();

   
    public BulletPool(BulletBehaviour.Pool bulletPool)
    {
        this.bulletPool = bulletPool;
    }

    public void AddBullet(GameObject cannon)
    {
        bulletBehaviourList.Add(bulletPool.Spawn(cannon));
        
    }

    public void RemoveBullet(BulletBehaviour bullet)
    {
       // var bullet = bulletBehaviourList[0];
        bulletPool.Despawn(bullet);
        
        bulletBehaviourList.Remove(bullet);
    }
}