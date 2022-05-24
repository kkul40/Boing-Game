using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject[] Platforms;

    public float height;

    public float minX;
    public float spawnDuration;
    private float lastSpawnTime;

    private void Start()
    {
        GameObject instance = Instantiate(Platforms[0]);
        instance.transform.position = new Vector3(0, height, 0);

        instance = Instantiate(Platforms[0]);
        instance.transform.position = new Vector3(1, height, 0);
    }

    private void FixedUpdate()
    {
        if (PlayerController.start && !PlayerController.isFalling)
        lastSpawnTime += Time.deltaTime;

        if (lastSpawnTime > spawnDuration && PlayerController.start)
        {
            lastSpawnTime = 0;

            int temp = Random.Range(0, Platforms.Length);

            GameObject instance = Instantiate(Platforms[temp]);
            instance.transform.position = new Vector3(minX * GameManager.speed, height, 0);

        }
    }

}
