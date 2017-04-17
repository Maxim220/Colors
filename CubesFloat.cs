using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesFloat : MonoBehaviour {

    public float speed;
    private Vector3 target = new Vector3 ( 0, 2.5f, 0) ;
    public float tilt;

	void Update () {
        transform.position = Vector3.MoveTowards (transform.position , target , Time.deltaTime * speed ) ;
        if (transform.position == target && target.y != 1f)
            target.y = 1f;
        else if (transform.position == target && target.y == 1f)
            target.y = 2.5f;
        transform.Rotate(Vector3.up * Time.deltaTime * tilt);
	}
}
