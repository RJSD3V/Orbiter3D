using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    public ParticleSystem explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("shot"))
        {
            Explode();
        }
        
    }

    void Explode()
    {
        Instantiate(explosion, gameObject.transform.position,gameObject.transform.rotation);
        Destroy(gameObject);
        explosion.Play();
    }
}
