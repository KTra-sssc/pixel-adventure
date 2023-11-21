using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollow : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoint;
    [SerializeField] private float speed = 2f;

    private int waypointInd = 0;
    void Update()
    {
        if (Vector2.Distance(waypoint[waypointInd].transform.position, transform.position) < .1f)
        {
            waypointInd++; 
            waypointInd = waypointInd % waypoint.Length;
        }

        transform.position = Vector2.MoveTowards(transform.position, waypoint[waypointInd].transform.position, speed * Time.deltaTime);
    }
}
