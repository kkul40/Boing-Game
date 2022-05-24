using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformController : MonoBehaviour
{
    public GameManager gameManager;


    public float destructionPosX;


    private void Start()
    {
        gameManager = new GameManager();
    }

    private void FixedUpdate()
    {

        Debug.Log(gameManager.speed);


        transform.position += new Vector3(-gameManager.speed * Time.deltaTime, 0f, 0f);
        /*if (start && !fall)
        {
            transform.position += new Vector3(-gameManager.speed * Time.deltaTime, 0f, 0f);

        }

        if (transform.position.x < destructionPosX)
        {
            Destroy(gameObject);   
        }*/



    }

}
