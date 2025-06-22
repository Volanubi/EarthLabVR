using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTriggered : MonoBehaviour
{
    public Fade fadeScreen;

    void SomeEventTriggered()
    {
        fadeScreen.StartTimeSkip("Next Morning...");
    }
}
