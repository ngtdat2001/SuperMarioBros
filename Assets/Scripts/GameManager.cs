using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int world { get; private set; }
    public int stage { get; private set; }
    public int lives { get; private set; }
    public int coins { get; private set; }
    public int score { get; private set; }
    public static int Lives = 0;
    public static int Coins = 0;
    public static int Score = 0;
    public static int World = 0;
    public static int Stage = 0;
    
    private void Awake()
    {
        if(Instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void OnDestroy()
    {
        if(Instance == this)
        {
            Instance = null;
        }
    }

    private void Start()
    {
        Application.targetFrameRate = 60;

        NewGame();
    }

    private void NewGame()
    {
        lives = 3;
        coins = 0;
        score = 0;
        LoadLevel(1, 1);

        Lives = lives;
        Coins = coins;
        Score = score;
        World = world;
        Stage = stage;
    }

    public void LoadLevel(int world, int stage)
    {
        this.world = world;
        this.stage = stage;

        SceneManager.LoadScene($"{world}-{stage}");

        World = world;
        Stage = stage;
    }

    //public void NextLevel()
    //{
        //LoadLevel(world, stage + 1);
    //}

    public void ResetLevel(float delay)
    {
        Invoke(nameof(ResetLevel), delay);
    }

    public void ResetLevel()
    {
        lives--;

        if(lives > 0)
        {
            LoadLevel(world, stage);
        }
        else
        {
            GameOver();
        }
        Lives = lives;
    }

    private void GameOver()
    {
        SoundManager.PlaySound("GameOver");
        NewGame();
    }

    public void AddCoin(){
        coins++;
        score += 200;

        if(coins == 100){
            AddLife();
            coins = 0;
        }

        Coins = coins;
        Score = score;
    }

    public void AddLife(){
        lives++;
        score += 1000;
        Lives = lives;
    }

    public void AddPUScore(){
        score += 1000;
        Score = score;
    }

    public void AddEScore(){
        score += 100;
        Score = score;
    }
}
