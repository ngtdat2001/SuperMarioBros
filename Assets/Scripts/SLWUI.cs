using UnityEngine;
using TMPro;

public class SLWUI : MonoBehaviour
{
    public TMP_Text coin;
    public TMP_Text score;
    public TMP_Text lives;
    public TMP_Text worldStage;
    // Update is called once per frame
    private void Update()
    {
        coin.text = "Coins: " + GameManager.Coins.ToString();
        score.text = "Score: " + GameManager.Score.ToString();
        lives.text = "Lives: " + GameManager.Lives.ToString();
        worldStage.text = "World " + GameManager.World.ToString() + "-" + GameManager.Stage.ToString();
    }
}
