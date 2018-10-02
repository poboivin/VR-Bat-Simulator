using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    [SerializeField]
    float roundTimeInSeconds = 120f;
    [SerializeField]
    private int scoreGoal = 4000;
    [SerializeField]
    private int score = 0;

    public Transform ScorePrefab;
    public void SpawnScore(Vector3 pos, int amount)
    {
        Instantiate(ScorePrefab, pos, Quaternion.identity).GetComponent<ScoreSpawn>().Display.text = amount.ToString()+"$";
    }
    public void AddScore(int amount)
    {
        score += amount;
    }
    public void SetScore(int amount)
    {
        score = amount;
    }
    public int GetScore()
    {
        return score;
    }
    public void Update()
    {
        roundTimeInSeconds -= Time.deltaTime;

        if(roundTimeInSeconds <= 0)
        {
            Debug.Log("game Over");
        }
}
}
