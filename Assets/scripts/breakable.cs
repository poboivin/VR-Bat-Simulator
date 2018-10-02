using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakable : MonoBehaviour {
    public Transform brokenPrefab;
    public int Score = 50;
	// Use this for initialization
	void Start () {
		
	}

    public void Break()
    {
        Instantiate(brokenPrefab, transform.position, transform.rotation);
       
        if (GameObject.FindObjectOfType<ScoreManager>() != null)
            GameObject.FindObjectOfType<ScoreManager>().AddScore(Score);
        GameObject.Destroy(this.gameObject);


    }
    // Update is called once per frame
    void Update () {
		
	}
}
