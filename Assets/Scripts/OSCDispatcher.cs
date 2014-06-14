using UnityEngine;
using System.Collections;
using OSC;

public class OSCDispatcher : MonoBehaviour {
	
	[SerializeField]
	int port = 7000;
	
	[SerializeField]
	string hostname = "localhost";
	
	OSCManager oscManager;

	void OnEnable() {
		oscManager = OSCManager.instance;
		oscManager.LocalPort = port;
	}
	
	void OnDisable() {
		
	}

    public void AddListener(OSCManager.OscMessageDelegate listener){
        oscManager.OnMessage += listener;
    }



    
}
