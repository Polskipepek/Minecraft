using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : MonoBehaviour {
    public Queue<IPlaceable> Placeables { get; set; }
    protected Spawner _getInstance;
    protected Spawner () { }
    public abstract void Spawn ();

}
