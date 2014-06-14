using UnityEngine;
using System.Collections;

public class NoiseFilter : MonoBehaviour {

    public string filteredVariable;

    public float damping = 10f;
    public float mass = 1;
    public float elastic = 150f;
    

   
    private float v = 0;
    private float x = 0;
    private float destination = 0;

	
	void Start () {
	
	}
	
	
	void Update () {
        float dt = Time.deltaTime;

        float a = destination - x;
        a *= (elastic / mass);
        a -= (damping / mass) * v;

        v += a * dt;
        x += v * dt;
	}

    public void SetInitial(float dest) {
        x = dest;
        destination = dest;
    }

    public void Set(float dest) {
        destination = dest;
    }
    public float Get()
    {
        return x;
    }
}
