using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public float speed;
    public void MoveRight()
    {
        Move(Vector3.right);
    }
    public void MoveLeft()
    {
        Move(Vector3.left);
    }
    private void Move(Vector3 dir)
    {
        transform.Translate(dir * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(this.gameObject);
    }
}
