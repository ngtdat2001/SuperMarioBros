using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public enum Type{
        Coin,
        ExtraLife,
        MagicMushroom,
        Starpower,
    }

    public Type type;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            Collect(other.gameObject);
        }
    }

    private void Collect(GameObject player){
        switch(type){
            case Type.Coin:
                GameManager.Instance.AddCoin();
                SoundManager.PlaySound("Coins");
                break;
            case Type.ExtraLife:
                GameManager.Instance.AddLife();
                SoundManager.PlaySound("1Up");
                break;
            case Type.MagicMushroom:
                player.GetComponent<Player>().Grow();
                GameManager.Instance.AddPUScore();
                SoundManager.PlaySound("PowerUp");
                break;
            case Type.Starpower:
                player.GetComponent<Player>().Starpower();
                GameManager.Instance.AddPUScore();
                SoundManager.PlaySound("Invincible");
                break;
        }

        Destroy(gameObject);
    }
}
