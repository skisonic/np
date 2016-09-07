using UnityEngine;
using System.Collections;

public class SpawnerBehavior : MonoBehaviour {


    SpawnerStats spwnStats;
    SpriteRenderer rend;

	// Use this for initialization
	void Start () {
        spwnStats = gameObject.GetComponent<SpawnerStats>();
        rend = gameObject.GetComponent<SpriteRenderer>();


        switch (spwnStats.type)
        {
            case SpawnerStats.SpawnerType.red:
                rend.sprite = spwnStats.spawnerSprites[0];
                Debug.Log("spawner red");
                break;
            case SpawnerStats.SpawnerType.green:
                rend.sprite = spwnStats.spawnerSprites[1];
                Debug.Log("spawner green");
                break;
            case SpawnerStats.SpawnerType.blue:
                rend.sprite = spwnStats.spawnerSprites[2];
                Debug.Log("spawner blue");
                break;
            default:
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
	}
}
