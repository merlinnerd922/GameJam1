using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public GameObject Bullet;
	public GameObject MuzzleLeft;
	public GameObject MuzzleRight;

    CharacterController controller;
	// Use this for initialization
	void Start () {
        Debug.Log("Hello World");
        controller = this.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        //Move
        this.transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal"), 0));
        controller.Move(this.transform.forward * Input.GetAxis("Vertical"));
	
        //Shoot bullets
        if (Input.GetAxis("Fire2") > 0)
        {
           GameObject bullet = (GameObject)Instantiate(Bullet, this.MuzzleRight.transform.position, Quaternion.identity);
           bullet.rigidbody.AddForce(this.transform.forward * 500);
        }
		if (Input.GetAxis("Fire1") > 0)
		{
		   GameObject bullet = (GameObject)Instantiate(Bullet, this.MuzzleLeft.transform.position, Quaternion.identity);
		   bullet.rigidbody.AddForce(this.transform.forward * 500);
		}
    }
}
