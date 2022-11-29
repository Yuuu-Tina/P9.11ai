using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g_movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        if(agent.remainingDistance <=1.0f){
            float x = Random.Range(-100.0f, 100.0f);
            float z = Random.Range(-100.0f, 100.0f);
            agent.destination = new Vector3(x,0.0f,z);
        }
    }
     
   

}
