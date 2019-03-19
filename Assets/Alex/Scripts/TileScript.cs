using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {

    public Animation anim;

    // Use this for initialization
    void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            PlaceTower();
        }
    }

    private void PlaceTower()
    {
        Debug.Log("Placing a tower");
        //Instantiate(GameManager.Instance.LightHouse1, transform.position + (Vector3.right * 0.8f) + (Vector3.back *-0.9f) , Quaternion.identity);
        Destroy(Instantiate(GameManager.Instance.LightHouse1, transform.position + (Vector3.right * 0.8f) + (Vector3.back * -0.9f), Quaternion.identity), 10);
    }
}
