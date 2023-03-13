using UnityEngine;
using System.Collections;

public class RespawnFinder : MonoBehaviour {
    public GameObject[] respawnPoints;

	// Use this for initialization
	void Start () {
        respawnPoints = GameObject.FindGameObjectsWithTag("Respawn");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
