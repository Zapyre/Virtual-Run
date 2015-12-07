using UnityEngine;
using System.Collections;

public class CameraBehaviour : MonoBehaviour {
    private GameObject mainCamera;
    private Vector3 playerPosition;
	// Use this for initialization
	void Start () {
        mainCamera = GameObject.Find("Main Camera");
        playerPosition = GameObject.Find("Player").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        mainCamera.transform.position = new Vector3(playerPosition.x, playerPosition.y + 9.0f, playerPosition.z);
        Debug.Log(mainCamera.transform.position);
        Debug.Log(playerPosition);
    }
}
