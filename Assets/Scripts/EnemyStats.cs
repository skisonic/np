using UnityEngine;
using System.Collections;

public class EnemyStats : MonoBehaviour {

    public Sprite[] EnemySprites;
    public enum EnemyType { Red, Green, Blue};
    public EnemyType type;


    public float flDuration;
    public float flSpeed;
    public float flTimeout;
    public float damage;
    public bool isFlying;


    // Use this for initialization
    void Start () {
        isFlying = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
