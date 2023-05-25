using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip shellHit ,bumpSound, coinsSound, jumpSound, livesUpSound, flagPoleSound, gameOverSound, deadSound, pipeSound, powerUpSound, pUAppearSound, stageClearSound, stompSound, starSound;
    static AudioSource audiosrc;
    private void Start() {
        bumpSound = Resources.Load<AudioClip>("HitBrick");
        coinsSound = Resources.Load<AudioClip>("Coins");
        jumpSound = Resources.Load<AudioClip>("Jump");
        livesUpSound = Resources.Load<AudioClip>("1Up");
        flagPoleSound = Resources.Load<AudioClip>("FlagPole");
        gameOverSound = Resources.Load<AudioClip>("GameOver");
        deadSound = Resources.Load<AudioClip>("Dead");
        pipeSound = Resources.Load<AudioClip>("Pipe");
        powerUpSound = Resources.Load<AudioClip>("PowerUp");
        pUAppearSound = Resources.Load<AudioClip>("PUAppear");
        stageClearSound = Resources.Load<AudioClip>("StageClear");
        stompSound = Resources.Load<AudioClip>("Stomp");
        starSound = Resources.Load<AudioClip>("Invincible");
        shellHit = Resources.Load<AudioClip>("ShellHit");

        audiosrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip){
        switch(clip){
        case "HitBrick":
            audiosrc.PlayOneShot(bumpSound);
            break;
        case "Coins":
            audiosrc.PlayOneShot(coinsSound);
            break;
        case "Jump":
            audiosrc.PlayOneShot(jumpSound);
            break;
        case "1Up":
            audiosrc.PlayOneShot(livesUpSound);
            break;
        case "FlagPole":
            audiosrc.PlayOneShot(flagPoleSound);
            break;
        case "GameOver":
            audiosrc.PlayOneShot(gameOverSound);
            break;
        case "Dead":
            audiosrc.PlayOneShot(deadSound);
            break;
        case "Pipe":
            audiosrc.PlayOneShot(pipeSound);
            break;
        case "PowerUp":
            audiosrc.PlayOneShot(powerUpSound);
            break;
        case "PUAppear":
            audiosrc.PlayOneShot(pUAppearSound);
            break;
        case "StageClear":
            audiosrc.PlayOneShot(stageClearSound);
            break;
        case "Stomp":
            audiosrc.PlayOneShot(stompSound);
            break;
        case "Invincible":
            audiosrc.PlayOneShot(starSound);
            break;
        case "ShellHit":
            audiosrc.PlayOneShot(shellHit);
            break;
        }
    } 
}
