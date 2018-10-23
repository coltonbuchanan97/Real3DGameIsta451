using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCon : MonoBehaviour {
    public float lifetime;
    float currentLife;
    public float speed;

    public shotGun owner;

    void Update()
    {
        currentLife += Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (currentLife > lifetime)
        {
            Destroy(this.gameObject);
            owner.ProjectileDestroyed(this);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}
