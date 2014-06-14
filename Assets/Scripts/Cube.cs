using UnityEngine;
using System.Collections;
using OSC;

public class Cube : MonoBehaviour {

    public OSCDispatcher dispatcher;
    public string address;
    private Vector3 p0;
    public float scale;

	// Use this for initialization
	void Start () {
        dispatcher.AddListener(OnMessage);
        p0 = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMessage(OSCMessage message)
    {
        // ignore other messages
        if (message.Address != address) return;

        ArrayList values = message.Values;

        float x = (float) values[0];
        float y = (float) values[1];
        Vector3 pos = transform.position;
        pos.x = p0.x + x * scale;
        pos.z = p0.z + y * scale;
        transform.position = pos;

    }
}
