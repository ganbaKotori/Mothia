using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager> {

    [SerializeField]
    private GameObject LightHouse;

    public GameObject LightHouse1
    {
        get
        {
            return LightHouse;

        }

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
