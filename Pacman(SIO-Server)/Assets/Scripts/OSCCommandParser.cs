using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;

[RequireComponent(typeof(OSCReceiver))]
public class OSCCommandParser : MonoBehaviour
{
    OSCReceiver osc_receiver;

    public string playerLocalAddress = "/game/command/player";


    // Start is called before the first frame update
    void Start()
    {
        osc_receiver = this.GetComponent<OSCReceiver>();
        osc_receiver.Bind(playerLocalAddress, PlayerCommandReceived);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void PlayerCommandReceived(OSCMessage osc_message)
    {
        Debug.Log("player cmd: " + osc_message);
    }
}
