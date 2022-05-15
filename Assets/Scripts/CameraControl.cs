using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    public Transform player;

    void Update () {
        transform.position = player.transform.position + new Vector3(0, 0, -5);
    }
}