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
        ScoreManager manager = GameObject.FindObjectOfType<ScoreManager>();
        if (manager != null)
        {
            manager.AddScore(Score);
            manager.SpawnScore(this.transform.position, Score);
        }
        GameObject.Destroy(this.gameObject);


    }
    // Update is called once per frame
    void Update () {
		
	}
}
