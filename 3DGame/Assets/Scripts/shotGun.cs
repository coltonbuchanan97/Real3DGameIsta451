using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotGun : MonoBehaviour {

    public BulletCon projectile;
    private float projectileSpawnDistance = 0;

    private int maxProjectiles = 30;

    public List<BulletCon> projectiles = new List<BulletCon>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (projectiles.Count > maxProjectiles) return;

            BulletCon newProjectile = Instantiate<BulletCon>(projectile);
            newProjectile.transform.position = transform.position + transform.forward * projectileSpawnDistance;
            projectiles.Add(newProjectile);
            newProjectile.owner = this;
        }
    }

    public void ProjectileDestroyed(BulletCon dyingProjectile)
    {
        projectiles.Remove(dyingProjectile);
    }
}


