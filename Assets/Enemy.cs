using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public Player Player;
    public float Speed = 100;

    CharacterController controller;
	void Start () {
        controller = this.GetComponent<CharacterController>();
        Player = FindObjectOfType<Player>();
	}
	
	void Update () {
        //Move towards player
        this.transform.LookAt(Player.transform);
        controller.Move(this.transform.forward * Speed * Time.deltaTime);
	}

    void OnControllerColliderHit(ControllerColliderHit collider)
    {
        if (collider.collider.gameObject.tag == "Player")
        {
            FindObjectOfType<GameManager>().Restart();
        }
    }

}
