using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player player;
    public PoolManager pool;
    public float gameTime;
    public float maxgameTime = 2 * 10f;

    private void Awake()
    {
        instance = this;

    }
    void Update()
    {
        gameTime += Time.deltaTime;

        if (gameTime > maxgameTime)
        {
            gameTime = maxgameTime;
        }
    }
}
