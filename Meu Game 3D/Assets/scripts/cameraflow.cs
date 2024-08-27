using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
public class cameraflow : MonoBehaviour
{
   Transform alvo;
   public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
      alvo = GameObject.FindGameObjectWithTag("Player").transform;
      offset = transform.position - alvo.position;

    }

    // Update is called once per frame
    void Update()
    {
       transform.position = alvo.position + offset; 
    }
}
