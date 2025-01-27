﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCube : Cube {
    // Start is called before the first frame update
    void Start () {
        gameObject.tag = "Enemy";
    }

    // Update is called once per frame
    void Update () {
        Move(transform);
    }

    private void OnTriggerEnter (Collider other) {
        if (other.CompareTag ("Finish")) {
            GetComponent<Rigidbody> ().isKinematic = false;
            Destroy (gameObject, 1.5f);
        }
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }
}