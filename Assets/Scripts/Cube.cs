using UnityEngine;
using System.Collections;
using OSC;

public class Cube : MonoBehaviour {

    public OSCDispatcher dispatcher;
    private Vector3 p0;

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
        Debug.Log(message.Address);
        ArrayList values = message.Values;
        for (int i = 0; i < values.Count; i++) {
            Debug.Log(values[i]);
        }

        float x = (float) values[0];
        float y = (float) values[1];
        Vector3 pos = transform.position;
        pos.x = p0.x + x;
        pos.z = p0.z + y;
        transform.position = pos;

    }
}
