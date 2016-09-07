using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {


    private PlayerStats stats;

	// Use this for initialization
	void Start () {
        stats = GetComponent<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            stats.health--;
            Debug.Log("got hit - collision");
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            stats.health--;
            Debug.Log("got hit - trigger");
        }
        Destroy(coll.gameObject);
    }
}
