using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAt;


    private void FixedUpdate()
    {

        transform.position = new Vector3(lookAt.position.x + 0.5f, 0f, -10);


    }

}
