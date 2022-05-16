using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PlayerScript : MonoBehaviour
{
    public NavMeshAgent agent;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }


    void movePlayer()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("mouse");
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            print(ray);
            RaycastHit hit;
            //checks if the ray hits a collider
            if(Physics.Raycast(ray, out hit))
            {
                print(hit);
                agent.SetDestination(hit.point);
            }
        }
    }
}
