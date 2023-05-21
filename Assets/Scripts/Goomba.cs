using System;
using UnityEngine;

public class Goomba : MonoBehaviour
{
    public Sprite flatSprite;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player player = collision.gameObject.GetComponent<Player>();
            if (player.starpower)
            {
                Hit();
                GameManager.Instance.AddEScore();
            }
            else if (collision.transform.DotTest(transform, Vector2.down))
            {
                Flatten();
                GameManager.Instance.AddEScore();
            }
            else
            {
                player.Hit();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Shell"))
        {
            Hit();
            GameManager.Instance.AddEScore();
        }
    }
    private void Flatten()
    {
        GetComponent<Collider2D>().enabled = false;
        GetComponent<EntityMovement>().enabled = false;
        GetComponent<AnimatedSprite>().enabled = false;
        GetComponent<SpriteRenderer>().sprite = flatSprite;
        Destroy(gameObject, 0.5f);
    }

    private void Hit()
    {
        GetComponent<AnimatedSprite>().enabled = false;
        GetComponent<DeathAnimation>().enabled = true;
        transform.eulerAngles = new Vector3(180.0f, 0.0f, 0.0f);
        Destroy(gameObject, 3f);
    }
}
