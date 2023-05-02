using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;
    public float zSpeed;

    void Update()
    {
        transform.Rotate(new Vector3(xSpeed, ySpeed, zSpeed) * Time.deltaTime);

    }
}
