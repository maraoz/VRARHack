using UnityEngine;
using System.Collections;

public class ScaleModifier : MonoBehaviour {


	int MAX_SCALE = 100;

	Vector3 initialScale ;
	Vector3 maxScale;
	int volume;

	// Use this for initialization
	void Start () {
		initialScale = transform.localScale;
		maxScale = initialScale + new Vector3(0.1f*MAX_SCALE, 0.1f*MAX_SCALE, 0.1f*MAX_SCALE);
	}
	
	// Update is called once per frame
	void Update () {
		if(volume > 0) {
			if (transform.localScale.x < maxScale.x) {
				transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
			}
			volume--;

		} else {
			if (transform.localScale.x > initialScale.x) {
				transform.localScale -= new Vector3(0.15f, 0.15f, 0.15f);
			}
		}
	}

	public void setVolume(int v) {
		volume = v;
	}

	void OnMouseUpAsButton(){
		volume = 50;
		GameObject go = GameObject.Find("Sphere02");
		ScaleModifier other = (ScaleModifier) go.GetComponent(typeof(ScaleModifier));
		other.setVolume(100);

	}

}
