using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {

    private EnemyStats enemyStats;
    public GameObject player;

    SpriteRenderer rend;

    float birthtime, startTime, interval;
    float x, y;

    // Use this for initialization
    void Start () {
        rend = GetComponent<SpriteRenderer>();
        enemyStats = GetComponent<EnemyStats>();
        enemyStats.flDuration = Random.Range(1.0f, 5.0f);
        enemyStats.flSpeed = 0.02f;
        //enemyStats.flTimeout = Random.RandomRange(3.0f, 7.0f);
        enemyStats.flTimeout = 0;
        startTime = Time.time;
        birthtime = Time.time;

        player = GameObject.Find("Player");
        x = 1;
        y = 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (enemyStats.isFlying)
        {
            //movememnt
            switch (enemyStats.type)
            {
                case EnemyStats.EnemyType.Red:
                    transform.position = Vector2.MoveTowards(transform.position, player.transform.position, enemyStats.flSpeed);
                    break;
                case EnemyStats.EnemyType.Blue:
                    //transform.position = Mathf.Sin(x) * Vector2.MoveTowards(transform.position, player.transform.position, enemyStats.flSpeed);
                    transform.position =  Vector2.MoveTowards(transform.position, player.transform.position * Mathf.Sin(x) , enemyStats.flSpeed);
                    break;
                case EnemyStats.EnemyType.Green:
                    transform.position = Vector2.MoveTowards(transform.position, player.transform.position, enemyStats.flSpeed);
                    break;
                default:
                    break;
            }
            if (interval >= enemyStats.flDuration)
            {
                //stop flying
                enemyStats.isFlying = false;
                startTime = Time.time;
               // Debug.Log("stopping flight");
            }
        }
        else
        {
            // wait through timeout and turn to is flying.
            if (interval >= enemyStats.flTimeout)
            {
                // start flying
                enemyStats.isFlying = true;
                startTime = Time.time;
                //Debug.Log("starting flight towards" + player.transform.position);
            }
        }
        interval = Time.time - startTime;
        if (x <= 0)
        {
            x = 1;
        }
        else
        {
            x = x - 1 / 60;
        }
    }
}
