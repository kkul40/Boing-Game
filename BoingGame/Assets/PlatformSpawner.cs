using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject[] Platforms;

    private GameManager gameManager;


    public float minX;
    public float maxX;
    public float height;
    public float destructionPosX;

    public float spawnDuration;
    private float lastSpawnTime;


    private void FixedUpdate()
    {
        lastSpawnTime += Time.deltaTime;


        if (lastSpawnTime > spawnDuration && gameManager.playerInfo.start)
        {
            lastSpawnTime = 0;
            GameObject instance = Instantiate(Platforms[0]);
            instance.transform.position = new Vector3(minX, 0, 0);
        }

    }


}
