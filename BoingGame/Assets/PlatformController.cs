using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformController : MonoBehaviour
{

    private void FixedUpdate()
    {

        if (PlayerController.start && !PlayerController.isFalling)
        {
            transform.position += new Vector3(-GameManager.speed * Time.deltaTime, 0f, 0f);

        }

        if (transform.position.x < -3)
        {
            Destroy(gameObject);   
        }

    }


}
