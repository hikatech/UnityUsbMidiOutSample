using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V1HDController : MonoBehaviour {

    void Start () {
        MidiBridge.instance.Warmup();
        Debug.Log("*** input selecttion:  'A'=A-1  |  'S'=A-2***");
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            // source select A-1
            MidiOut.SendControlChange(MidiChannel.Ch1, 0, 0);
            MidiOut.SendControlChange(MidiChannel.Ch1, 32, 0);
            MidiOut.SendProgramChange(MidiChannel.Ch1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            // source select A-2
            MidiOut.SendControlChange(MidiChannel.Ch1, 0, 0);
            MidiOut.SendControlChange(MidiChannel.Ch1, 32, 0);
            MidiOut.SendProgramChange(MidiChannel.Ch1, 1, 0);
        }
    }
}
