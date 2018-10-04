using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class ScoreManager : MonoBehaviour {
    public Transform EndGameCanvas;
    public Transform Bat;
    public Text ScoreDisplay;
    public Text EndScoreDisplay;
    public Text EndScoreGoalDisplay;
    public Text Total;

    public Text Seconds;
    [SerializeField]
    float roundTimeInSeconds = 120f;
    [SerializeField]
    private int scoreGoal = 4000;
    [SerializeField]
    private int score = 0;
    public UnityEvent OnGameOver;
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
    public void EndGame()
    {
        if (Bat)
        {
            Destroy(Bat.gameObject);
        }
        EndScoreGoalDisplay.text = "Max Payout: " + scoreGoal.ToString();
        EndScoreDisplay.text = "Damage: " + score.ToString();
        EndGameCanvas.gameObject.SetActive(true);
        if(score > scoreGoal)
        {
            Total.color = Color.red;
            Total.text = "Payout: " + (scoreGoal -score ).ToString();
        }
        else
        {
            Total.color = new Color(.2f, .5f, .2f);
            Total.text = "Payout: " + score.ToString();
        }
        OnGameOver.Invoke();
    }
    public void Start()
    {
        ScoreDisplay.text = "Goal: " + scoreGoal.ToString();

    }
    public void Update()
    {
        roundTimeInSeconds -= Time.deltaTime;
        Seconds.text = Mathf.CeilToInt(roundTimeInSeconds).ToString();
        if (roundTimeInSeconds <= 0)
        {
            EndGame();
            Debug.Log("game Over");
        }
    }
}
