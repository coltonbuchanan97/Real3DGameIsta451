using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float tilt;
    private float nextFire;
    public float fireRate;
    public Boundary boundary;
    public GameObject shot;
    public Transform shotSpawn1;
    public Transform shotSpawn2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            //GameObject clone = 
            Instantiate(shot, shotSpawn1.position, shotSpawn1.rotation); //as GameObject;
            GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            //GameObject clone = 
            Instantiate(shot, shotSpawn2.position, shotSpawn2.rotation); //as GameObject;
            GetComponent<AudioSource>().Play();
        }
    }

    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().velocity = movement * speed;

        GetComponent<Rigidbody>().position = new Vector3
            (Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax));

        GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);

    }

}