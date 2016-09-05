using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {

    public float speed;
    public float maxSpeed;

    public int firePower;
    public int waterPower;
    public int grassPower;
    public int magicPower;

    public int health = 100;

    public enum facingDir { right, down, left, up };

    public facingDir currentDir;

    // Use this for initialization
    void Start()
    {
        speed = 0.05f;
        maxSpeed = 1.0f; //not in use 
        currentDir = facingDir.right;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
