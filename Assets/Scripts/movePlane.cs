using UnityEngine;
using System.Collections;

public class movePlane : MonoBehaviour {

	public Vector3 speeds = new Vector3(Random.Range(0, 1), Random.Range(0, 1),Random.value);

	void Update () {
		transform.Rotate (speeds);
	}
}
