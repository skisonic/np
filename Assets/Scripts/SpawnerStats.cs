using UnityEngine;
using System.Collections;

public class SpawnerStats : MonoBehaviour {

    public Sprite[] spawnerSprites;
    public enum SpawnerType {red, green, blue};
    public SpawnerType type;

    public int hp = 1; // num of hits to die

    SpriteRenderer rend;

    // Use this for initialization
    void Start () {
        rend = gameObject.GetComponent<SpriteRenderer>();

        /*
        switch (type)
        {
            case SpawnerStats.SpawnerType.red:
                rend.sprite = spawnerSprites[0];
                Debug.Log("spawner red");
                break;
            case SpawnerStats.SpawnerType.green:
                rend.sprite = spawnerSprites[1];
                Debug.Log("spawner green");
                break;
            case SpawnerStats.SpawnerType.blue:
                rend.sprite = spawnerSprites[2];
                Debug.Log("spawner blue");
                break;
            default:
                break;
        }
        */

        if (type == SpawnerType.red)
        {
            rend.sprite = spawnerSprites[0];
            Debug.Log("spawner RED RED");
        }
        else if (type == SpawnerType.green)
        {
            rend.sprite = spawnerSprites[1];
            Debug.Log("spawner GREEN GREEN");
        }
        else if (type == SpawnerType.blue)
        {
            rend.sprite = spawnerSprites[2];
            Debug.Log("spawner BLUE BLUE");
        }


    }


    // Update is called once per frame
    void Update () {
	
	}
}
