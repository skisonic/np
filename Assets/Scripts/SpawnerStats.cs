using UnityEngine;
using System.Collections;

public class SpawnerStats : MonoBehaviour {

    public Sprite[] spawnerSprites;
    public enum SpawnerType { red, green, blue};
    public SpawnerType type;

    public int hp = 1; // num of hits to die


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
