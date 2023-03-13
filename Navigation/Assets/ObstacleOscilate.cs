using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(NavMeshObstacle))]
public class ObstacleOscilate : MonoBehaviour {

    public GameObject[] waypoints = new GameObject[0];
    public float speed = 5f;
    public float arrivalThreshold = 3f;


    private int currentWaypointIndex = 0;
    private GameObject currentWaypoint = null;
	
	// Update is called once per frame
	void Update () {
        UpdateWaypoint();

        if (currentWaypoint != null)
        {
            MoveTowardsWaypoint();
        }
	}

    private void MoveTowardsWaypoint()
    {
        Vector3 worldDelta = currentWaypoint.transform.position - transform.position;
        worldDelta.y = 0;
        Vector3 targetDirection = worldDelta / worldDelta.magnitude;

        transform.position += targetDirection * speed * Time.deltaTime;

        if (worldDelta.magnitude < arrivalThreshold)
        {
            currentWaypoint = null;
        }
    }

    private void UpdateWaypoint()
    {
        if (currentWaypoint == null)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }

            if (currentWaypointIndex < waypoints.Length)
            {
                currentWaypoint = waypoints[currentWaypointIndex];
            }
        }
    }
}
