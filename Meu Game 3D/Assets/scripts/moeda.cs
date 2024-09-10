using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    public int velocidadeGiro = 50;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<gamemanager>().SubtrairMoedas(1);
            Destroy(gameObject);
        }
    }
    void Update()
    {
        transform.Rotate(eulers:Vector3.forward * velocidadeGiro * Time.deltaTime);
    }
}




