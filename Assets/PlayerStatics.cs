using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatics : MonoBehaviour
{
    private static PlayerStatics _instance;

    public static PlayerStatics Instance { get { return _instance; } }

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
    public void FlipPlayerSprite(bool flipRight)
    {
        if(flipRight)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
