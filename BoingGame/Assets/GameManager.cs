using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerController playerInfo;

    public float speed = 1;

    private void Start()
    {
        playerInfo = new PlayerController();
    }

    private void FixedUpdate()
    {
        if (playerInfo.start && !playerInfo.isFalling)
        {
            speed += Time.deltaTime / 10;
        }


    }
}
