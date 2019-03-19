using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script controlling Enemies' life span
public class Life : MonoBehaviour {
    private int lives;
    private int totalLives;

    [Header("Unity Stuff")]
    public Image healthBar;

    // Use this for initialization
    void Awake()
    {
    }

    void Start()
    {    
        setLives(WaveSpawner.life);
        setTotalLives(WaveSpawner.life);
    }

    public void setLives(int newLife)
    {
        lives = newLife;
    }

    public void setTotalLives(int newLife)
    {
        totalLives = newLife;
    }

    public int getLives()
    {
        return lives;
    }

    public int getTotalLives()
    {
        return totalLives;
    }

    public void decLife()
    {
        setLives(getLives() - 1);
        float life = getLives();
        float total = getTotalLives();
        healthBar.fillAmount = life / total;
        Debug.Log(getLives() + "/" + getTotalLives());
    }
	
	// Update is called once per frame
	void Update () {
	    if (getLives() == 0) //What happens when the spider dies
        {
            Destroy(gameObject);
            WaveSpawner.spidersKilled += 1;
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Lighthouse")
        {
            decLife();
            GameScore.scoreValue += 100;

            Debug.Log(ScoreScript.scoreValue);
            //Destroy(gameObject);
        }
    }
}
