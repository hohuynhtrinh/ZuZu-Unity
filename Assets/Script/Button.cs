using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public Vector3 scale = Vector3.one;
	public int nextLevel = -1;
	private Vector3 sca;
	// Use this for initialization
	void Start () {
		sca = transform.lossyScale;
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetMouseButtonDown(0))
			//OnMouseDown();
	}

	void OnMouseDown() {
		this.transform.localScale = scale;
	}

	void OnMouseUp() {
		this.transform.localScale = sca;
		if (nextLevel >= 0) {
			Application.LoadLevel (nextLevel);
		}
	}
}
