using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {


    private PlayerStats stats;
    private SpriteRenderer sprite;

    public GameObject sword;
    private bool swordActive;
    private bool isRed;

	// Use this for initialization
	void Start () {
        stats = GetComponent<PlayerStats>();
        sword = GameObject.Find("theSword");
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update () {

        //swing sword
        if (Input.GetButtonDown("Fire1"))
        {
            //StartCoroutine(PokeSword());
            StartCoroutine(RedAttack());
        }

    }

    IEnumerator PokeSword()
    {
        if (swordActive.Equals(false))
        {
            switch(stats.currentDir)
            {
                case PlayerStats.facingDir.right:
                    break;
                case PlayerStats.facingDir.up:
                    sword.transform.localScale = new Vector3(-1, -1, 1);
                    //sword.transform.rotation = Quaternion.Euler(Vector3.forward * 180.0f);
                    Debug.Log("up up");
                    break;
            }
            if (stats.currentDir == PlayerStats.facingDir.left)
            {
                Quaternion theRotation = sword.transform.localRotation;
                //theRotation.z = -45f;
                //sword.transform.localRotation = theRotation;
                //sword.transform.rotation.z *=  90f;
                Debug.Log("rotate sword");
                sword.transform.rotation = Quaternion.Euler(Vector3.forward * -90.0f);
                //sword.transform.localScale = new Vector3(1, 1, -1);

            }
            else if (stats.currentDir == PlayerStats.facingDir.down)
            {
                sword.transform.rotation = Quaternion.Euler(Vector3.forward);
                sword.transform.localScale = new Vector3(1, 1, 1);
            }

            swordActive = true;
            sword.SetActive(true);
            yield return new WaitForSeconds(0.3f);
            sword.SetActive(false);
            swordActive = false;


            yield return 0;
        }
    }

    IEnumerator RedAttack()
    {
        if (isRed.Equals(false))
        {
            sprite.color = Color.red;

            isRed = true;
            yield return new WaitForSeconds(0.3f);
            sprite.color = Color.white;
            isRed = false;

            yield return 0;
        }
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
            if (isRed == false)
            {
                stats.health--;
            }
            //Debug.Log("got hit - trigger");
        }
        Destroy(coll.gameObject);
    }
}
