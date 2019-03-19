using UnityEngine;
using UnityEngine.SceneManagement;

public class WaveSpawner : MonoBehaviour {

    public Transform enemyPrefab;

    public Transform spawnPoint;

    public int spidersInLevel = 2;
    public int spiderCount = 0;
    

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    public static int life = 2;
    public static int spidersKilled = 0;

    private int waveNumber = 1;
    public SceneLoader loader;

    void Update()
    {
        if(spidersInLevel==spidersKilled)
        {
            Debug.Log("Level finished!");
            SceneManager.LoadScene("MainMenu");
            spidersKilled = 0;
            ScoreScript.scoreValue = 0;
            GameScore.scoreValue = 0;
            WaveSpawner.life = 2;
        }

        if (countdown <= 0f)
        {
            if (spidersInLevel > spiderCount)
            {
                Spawnwave();
                spiderCount++;
            } 
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;
    }

    void Spawnwave ()
    {
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
        }
       // waveNumber++;
    }

    void SpawnEnemy ()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        life += 1;
    }
}
