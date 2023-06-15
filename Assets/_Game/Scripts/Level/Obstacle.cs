using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour, IHit
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void OnHit(Bullet bullet, Character character)
    {

    }
    public void OnHitExit(Bullet bullet, Character character)
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // blur the material
            transform.GetComponent<MeshRenderer>().material.SetFloat("_BlurSize", 1f);
        }
    }
}
