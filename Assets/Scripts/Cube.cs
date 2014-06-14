using UnityEngine;
using System.Collections;
using OSC;

public class Cube : MonoBehaviour {

    public OSCDispatcher dispatcher;
    private Vector3 p0;
    public float movementScale = 10;
    private char index;

	// Use this for initialization
	void Start () {
        dispatcher.AddListener(OnMessage);
        p0 = transform.position;
        index = name[name.Length - 1];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMessage(OSCMessage message)
    {
        ArrayList values = message.Values;
        if (message.Address == ("/pos" + index))
        {
            OnPosition(values);
        }
           
        if (message.Address == ("/vol" + index))
        {
            //Debug.Log(index);
            OnVolume(values);
        }

        if (message.Address == "/hands")
        {
            OnHands(values);
        }

 

    }

    void OnPosition(ArrayList values)
    {
        float x = (float)values[0];
        float y = (float)values[1];
        Vector3 pos = transform.position;
        pos.x = p0.x + x * movementScale;
        pos.z = p0.z + y * movementScale;
        transform.position = pos;

    }

    void OnVolume(ArrayList values)
    {
        float v = (float)values[0];
        
        ScaleModifier sm = GetComponent<ScaleModifier>();
        sm.setVolume(v);
    }

    void OnHands(ArrayList values)
    {
        for (int i = 0; i < values.Count; i += 3)
        {
            float x = (float)values[i];
            float y = (float)values[i+1];
            float z = (float)values[i+2];

            /*
            Debug.Log("dedo");
            Debug.Log(x);
            Debug.Log(y);
            Debug.Log(z);
            */

        }
    }
}
