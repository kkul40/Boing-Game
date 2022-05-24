using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    private GameManager gameManager;


    public float destructionPosX;


    private void FixedUpdate()
    {
        if (gameManager.playerInfo.start && !gameManager.playerInfo.isFalling)
        {
            transform.position += new Vector3(-gameManager.speed * Time.deltaTime, 0f, 0f);

        }

        if (transform.position.x < destructionPosX)
        {
            Destroy(gameObject);   
        }



    }

}
