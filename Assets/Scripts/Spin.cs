using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {

    public Vector3 speeds = new Vector3(1.0f, 1.0f, 1.0f);

    void Update() {
        transform.Rotate(speeds);
    }
    
}
