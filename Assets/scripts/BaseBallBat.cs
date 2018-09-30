using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBallBat : MonoBehaviour {
    public float force;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "breakable")
        {
            if (collision.rigidbody != null)
            {
                Debug.Log("BOOM");
                // collision.rigidbody.AddForceAtPosition((collision.transform.position - this.transform.position) * force, collision.contacts[0].point,ForceMode.VelocityChange);
                collision.rigidbody.AddForceAtPosition((-collision.contacts[0].normal) * force, collision.contacts[0].point, ForceMode.VelocityChange);

            }

        }
    }
}
