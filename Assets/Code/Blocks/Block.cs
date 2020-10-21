using UnityEngine;

public class Block : MonoBehaviour, IBlock {
    public int Id => throw new System.NotImplementedException ();

    public string Name => throw new System.NotImplementedException ();

    public int LevelToDestroy => throw new System.NotImplementedException ();

    public int LevelToRecover => throw new System.NotImplementedException ();

    public IItem Prefab { get => throw new System.NotImplementedException (); }
}
