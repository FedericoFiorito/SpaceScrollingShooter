using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet : MonoBehaviour
{
    public float damage;
    public float speed;

    
    void Start()
    {

    }

    
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }

    void OnBecameInvisible()
    {
        GameObject.Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        other.gameObject.SendMessage("OnRecibirDano", damage, SendMessageOptions.DontRequireReceiver);
        GameObject.Destroy(gameObject);
    }
}
