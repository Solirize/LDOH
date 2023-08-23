using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerController : MonoBehaviour {
	Vector3 movementDir = Vector3.zero;
	// Start is called before the first frame update
	void Start() {
		Debug.Log("Hello World");
	}

	// Update is called once per frame
	void Update() {
		if (Input.GetKeyDown(KeyCode.F)) {
			//Player.Attack()
		} else {
			//Movement
			movementDir.z = Input.GetAxis("Vertical");
			movementDir.x = Input.GetAxis("Horizontal");
			if (movementDir.magnitude > 1.0f) {
				movementDir = movementDir.normalized;
			}
		}
	}

	private void FixedUpdate() {
		//Movement
		this.transform.position += movementDir;
	}
}
