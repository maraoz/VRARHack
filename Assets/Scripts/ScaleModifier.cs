using UnityEngine;
using System.Collections;

public class ScaleModifier : MonoBehaviour {


	public int MAX_SCALE = 2;

	Vector3 initialScale ;
	Vector3 maxScale;
	float volume;

    public NoiseFilter nf;

	// Use this for initialization
	void Start () {
		initialScale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
        float vm = nf.Get();
        
		transform.localScale = initialScale * (vm + 1);
	}

	public void setVolume(float v) {
        nf.Set(v);
	}


}
