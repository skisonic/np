using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayHealth : MonoBehaviour {


    public GameObject player;
    PlayerStats stats;
    Text hpText;

	// Use this for initialization
	void Start () {
        hpText = GetComponent<Text>();
        stats = player.GetComponent<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
        hpText.text = stats.health.ToString();
	}
}
