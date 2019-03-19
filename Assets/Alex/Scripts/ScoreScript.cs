using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour {

    [SerializeField] private string loadLevel;
    public static int scoreValue = 0;
    Text score;

	// Use this for initialization
	void Start () {
        score = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        score.text = "Spiders Escaped: " + scoreValue + "/ 3";
        if (scoreValue == 3)
        {
            scoreValue = 0;
            GameScore.scoreValue = 0;
            WaveSpawner.life = 2;
            SceneManager.LoadScene(loadLevel);

            
        }
		
	}
}
