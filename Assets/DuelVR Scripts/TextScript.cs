using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {
    float duration = 5;
    public Text text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > duration)
        {
            Destroy(gameObject);

        }
        Color myColor = text.color;
        float ratio = Time.time / duration;

        myColor.a = Mathf.Lerp(1, 0, ratio);
        text.color = myColor;

	}
}
