using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour {

    public float destroytime;
    float time;
	// Use this for initialization
	void Start () {
        time = 0;
        destroytime = 3;
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time > destroytime)
        {
            Destroy(this.gameObject);
        }
	}
}
