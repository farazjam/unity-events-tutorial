using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static System.Action BallSpawned;
    public GameObject ballPrefab;
    
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);
            BallSpawned?.Invoke(); // Or BallSpawned()
        }
    }
    
    // Parameterised events can also be fired
    //
    // Spawner.cs
    // public static System.Action<string> BallSpawned;
    // BallSpawned(ball.gameObject.name);
    //
    // Scorer.cs
    // Spawner.BallSpawned += OnBallSpawned;
    // void OnBallSpawned(string name) {}
}
