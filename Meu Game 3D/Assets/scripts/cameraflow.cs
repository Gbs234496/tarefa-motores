using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
public class cameraflow : MonoBehaviour
{
   Transform alvo;
   public Vector3 offset;
   public int suavidade = 5;
    //,mvm Start is called before the first frame update
    void Start()
    {
      alvo = GameObject.FindGameObjectWithTag("Player").transform;
      offset = transform.position - alvo.position;

    }

    // Update is called once per frame
    void Update()
    {   
        Vector3 posFinal = alvo.position + offset;
       transform.position = Vector3.Lerp(a:transform.position, b:posFinal, t:suavidade * Time.deltaTime);
    }
}
