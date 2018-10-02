using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreSpawn : MonoBehaviour {
   public Text Display;
    public float Speed = 0.3f;
    public float ScaleFactor = 4;
    public float time = 2f;
    private float maxTime;
    // Use this for initialization
    void Start () {
        maxTime = time;

    }
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        this.transform.Translate(Vector3.up * Speed * Time.deltaTime);
        transform.localScale = Vector3.Lerp( transform.localScale , transform.localScale / ScaleFactor, 1 / time /maxTime);
        Display.color = Color.Lerp(new Color(Display.color.r, Display.color.g, Display.color.b, 1), new Color(Display.color.r, Display.color.g, Display.color.b, 0f), 1/ time / maxTime);

        if (time <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
