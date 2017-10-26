using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public interface TimedInputHandler : IEventSystemHandler {

    // Use this for initialization
    void HandleTimedInput(); 
}
