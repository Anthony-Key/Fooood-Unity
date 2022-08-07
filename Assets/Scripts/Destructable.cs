using DefaultNamespace;
using UnityEngine;

[System.Serializable]
public abstract class Destructable : MonoBehaviour
{
    public float health = 100f;
    public DestructibleType destructibleType;
    public abstract void Kill();
}
