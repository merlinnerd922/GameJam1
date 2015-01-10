using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {


    float CreatedTime;
	void Start () {
        CreatedTime = Time.time;
	}
	
	void Update () {
        if (Time.time - CreatedTime > 1)
        {
            Destroy(this.gameObject);
        }
	}

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy" && active)
        {
            SpawnManager.KillCounter++;
            Destroy(collider.gameObject);
            Destroy(this.gameObject);
            this.active = false;
        }
    }
}
