using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Restart()
    {
        //Remove all existing enemies
        Enemy[] enemies = FindObjectsOfType<Enemy>();
        foreach (Enemy enemy in enemies)
        {
            Destroy(enemy.gameObject);
        }

        //Reset player position
        Player player = FindObjectOfType<Player>();
        player.transform.position = new Vector3(0f, 0.5f, 0f);

        //Reset kill count
        SpawnManager.KillCounter = 0;
    }
}
