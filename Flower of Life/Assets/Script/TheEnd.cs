using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnd : MonoBehaviour {

    // Use this for initialization
    float alpha;
	void Start () {
        alpha = 0;
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        transform.position = new Vector3(30, -3, -1);
        StartCoroutine(move());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator move()
    {
        float time = 0;
        while (time < 3)
        {
            alpha += Time.deltaTime / 3;
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha);
            transform.position += new Vector3(0, 1, 0)*Time.deltaTime;
            time += Time.deltaTime;
            yield return null;
        }
    }
}
