using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCarMovement : MonoBehaviour {

    public float carHorizontalSpeed = 2f;
    private Vector2 carPosition;

	// Use this for initialization
	void Start () {
        carPosition = this.gameObject.transform.position;
        Debug.Log("pozycja poczatkowa: " + carPosition);
    }
	
	// Update is called once per frame
	void Update () {

        carPosition.x += Input.GetAxis("Horizontal") * carHorizontalSpeed * Time.deltaTime;
        carPosition.x = Mathf.Clamp(carPosition.x, -2.3f, 2.3f);
        this.gameObject.transform.position = carPosition;


    }
}
