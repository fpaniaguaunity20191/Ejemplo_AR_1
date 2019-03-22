using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asterioide : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
