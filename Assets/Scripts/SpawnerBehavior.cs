using UnityEngine;
using System.Collections;

public class SpawnerBehavior : MonoBehaviour {


    SpawnerStats spwnStats;
    SpriteRenderer rend;

	// Use this for initialization
	void Start () {
        spwnStats = GetComponent<SpawnerStats>();
        rend = GetComponent<SpriteRenderer>();


        switch (spwnStats.type)
        {
            case SpawnerStats.SpawnerType.red:
                rend.sprite = spwnStats.spawnerSprites[0];
                break;
            case SpawnerStats.SpawnerType.green:
                rend.sprite = spwnStats.spawnerSprites[1];
                break;
            case SpawnerStats.SpawnerType.blue:
                rend.sprite = spwnStats.spawnerSprites[2];
                break;
            default:
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
	}
}
