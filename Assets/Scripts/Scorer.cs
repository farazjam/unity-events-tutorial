using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int spawnCount = 0;
    
    // Subscribe to ball spawn event. Whenever Spawner spawns a ball, it fires an event
    // That event is subscribed here, this script receive that event calls it's OnBallSpawned()
    // to do it's part accordingly
    private void OnEnable()
    {
        Spawner.BallSpawned += OnBallSpawned;
    }

    // It's important to unsubscribe the events as well
    private void OnDisable()
    {
        Spawner.BallSpawned -= OnBallSpawned;
    }
    
    void OnBallSpawned()
    {
        spawnCount++;
    }

    GUIStyle guiStyle = new GUIStyle();
    private void OnGUI()
    {
        guiStyle.fontSize = 72;
        GUILayout.Label("Click to Spawn Ball", guiStyle);
        GUILayout.Label("Spawn Count = " + spawnCount.ToString(), guiStyle);
    }
}
