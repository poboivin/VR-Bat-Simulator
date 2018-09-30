using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakable : MonoBehaviour {
    public Transform brokenPrefab; 
	// Use this for initialization
	void Start () {
		
	}

    public void Break()
    {
        Instantiate(brokenPrefab, transform.position, transform.rotation);
        GameObject.Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
