using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayStatics : MonoBehaviour
{
    private static GameplayStatics _instance;

    public static GameplayStatics Instance { get { return _instance; } }

    [SerializeField] private Player player;
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);

        }
        else
        {
            _instance = this;
        }

    }

    public void SpawnSoundAttached() { }
    public void SpawnSoundAtLocation() { }
    public void SpawnEmitterAttached() { }
    public void SpawnEmitterAtLocation() { }
    public bool IsAnimationPlaying(Animator anim, string stateName)
    {
        return anim.GetCurrentAnimatorStateInfo(0).IsName(stateName) &&
        anim.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f;
    }
    public Player GetPlayer()
    {
        return player;
    }
    public void FlipSprite(Transform flipTransform, bool flipRight)
    {
        if (flipRight)
        {
            flipTransform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            flipTransform.localScale = new Vector3(1, 1, 1);
        }
    }
}
