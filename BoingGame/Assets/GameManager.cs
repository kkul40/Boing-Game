using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static float speed = 1;

    private float time;

    public static int Skor;

    private void FixedUpdate()
    {
        time += Time.deltaTime;

        if (time >= 2)
        {
            speed += 1 * Time.deltaTime;
            time = 0;
        }
        Debug.Log(Skor);


    }
}
