using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {

    public float bounceScale = 10000;
	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        GameObject thing = other.gameObject;
        Rigidbody rb = thing.GetComponent<Rigidbody>();
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
        }
        else if (thing.CompareTag("Enemies"))
        {

        }
    }
}
