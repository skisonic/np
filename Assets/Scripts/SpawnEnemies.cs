using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour {

    public GameObject basicEnemyPrefab;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A) && GetComponent<SpawnerStats>().type.Equals(SpawnerStats.SpawnerType.red))
        {
            RedShot();
        }

        if (Input.GetKeyDown(KeyCode.Space) && GetComponent<SpawnerStats>().type.Equals(SpawnerStats.SpawnerType.green))
        {
            GreenShot();
        }

        if (Input.GetKeyDown(KeyCode.Quote) && GetComponent<SpawnerStats>().type.Equals(SpawnerStats.SpawnerType.blue))
        {
            BlueShot();
        }
    }

    void RedShot() {

        GameObject enemy = null;
        EnemyStats enemyStats;
        //red shot

        enemy = ((GameObject)Instantiate(basicEnemyPrefab, transform.position,
            Quaternion.Euler(0.0f, 0.0f, 0.0f)));
        enemyStats = enemy.GetComponent<EnemyStats>();
        enemy.GetComponent<SpriteRenderer>().sprite = enemy.GetComponent<EnemyStats>().EnemySprites[0];
        enemyStats.type = EnemyStats.EnemyType.Red;
        //enemyStats.dir = (EnemyStats.Dir)playerStats.currentDir;
        //enemyStats.lifetime = fireLifetime;
    }

    void GreenShot() {

        GameObject enemy = null;
        EnemyStats enemyStats;
        //red shot

        enemy = ((GameObject)Instantiate(basicEnemyPrefab, transform.position,
            Quaternion.Euler(0.0f, 0.0f, 0.0f)));
        enemyStats = enemy.GetComponent<EnemyStats>();
        enemy.GetComponent<SpriteRenderer>().sprite = enemy.GetComponent<EnemyStats>().EnemySprites[1];
        enemyStats.type = EnemyStats.EnemyType.Green;
        //enemyStats.dir = (EnemyStats.Dir)playerStats.currentDir;
        //enemyStats.lifetime = fireLifetime;
    }

        void BlueShot() {

        GameObject enemy = null;
        EnemyStats enemyStats;
        //red shot

        enemy = ((GameObject)Instantiate(basicEnemyPrefab, transform.position,
            Quaternion.Euler(0.0f, 0.0f, 0.0f)));
        enemyStats = enemy.GetComponent<EnemyStats>();
        enemy.GetComponent<SpriteRenderer>().sprite = enemy.GetComponent<EnemyStats>().EnemySprites[2];
        enemyStats.type = EnemyStats.EnemyType.Blue;
        //enemyStats.dir = (EnemyStats.Dir)playerStats.currentDir;
        //enemyStats.lifetime = fireLifetime;
    }

}
