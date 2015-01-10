using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour {

    public GameObject Enemy;
    public GameObject[] SpawnPoints;
    public int MaxEnemies;

    public Text KillCounterText;

    public static int KillCounter;

	void Start () {
	
	}
	
	void Update () {
        int numenemies = FindObjectsOfType<Enemy>().Length;

        if (numenemies < MaxEnemies)
        {
            KillCounterText.text = "Enemies Killed: " + KillCounter;
        }

        while (numenemies < MaxEnemies)
        {
            //Spawn Enemy
            Instantiate(Enemy, SpawnPoints[Random.Range(0, SpawnPoints.Length-1)].transform.position, Quaternion.identity);
            numenemies++;
        }
	}
}
