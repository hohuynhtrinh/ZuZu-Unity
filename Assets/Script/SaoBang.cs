using UnityEngine;
using System.Collections;

public class SaoBang : MonoBehaviour {

	Vector2 position;
	public Vector2 speed = Vector2.zero;
	public float len = 0.0f;

	// Use this for initialization
	void Start () {
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-speed.x, -speed.y, 0);
		if (position.x - transform.position.x >= len) {
			transform.position = position;		
		}
	}
}
