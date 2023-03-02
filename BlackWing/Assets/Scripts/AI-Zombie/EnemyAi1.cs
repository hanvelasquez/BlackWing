using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi1 : MonoBehaviour
{
    NavMeshAgent nm;
    public Transform target;
    public int range;
    // Start is called before the first frame update
    void Start()
    {
        nm = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
       //if (target <= range)
       // {
        nm.SetDestination(target.position);
       // }
    }
}
