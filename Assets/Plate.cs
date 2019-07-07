using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour {

    public Transform plate;
    float plateX;

    private void Start()
    {
        plateX = transform.position.x;
    }

    // Update is called once per frame
    void Update () {
        transform.position = new Vector3(plateX, plate.position.y, 0);
        transform.rotation = new Quaternion(0, 0, 0, 0);
	}
}
