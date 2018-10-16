using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotGun : MonoBehaviour {

    public BulletCon projectile;
    public float projectileSpawnDistance;

    public int maxProjectiles;

    public List<BulletCon> projectiles = new List<BulletCon>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (projectiles.Count > maxProjectiles) return;

            BulletCon newProjectile = Instantiate<BulletCon>(projectile);
            newProjectile.transform.position = transform.position + transform.right * projectileSpawnDistance;
            projectiles.Add(newProjectile);
            newProjectile.owner = this;
        }
    }

    public void ProjectileDestroyed(BulletCon dyingProjectile)
    {
        projectiles.Remove(dyingProjectile);
    }
}


