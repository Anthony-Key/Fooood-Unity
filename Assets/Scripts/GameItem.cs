using System.Collections;
using DefaultNamespace;
using UnityEngine;

[System.Serializable]
public abstract class GameItem : MonoBehaviour
{
    public GameObject destructibleMesh;
    public ParticleSystem particleSystem;
    public float timeToKill;
    public DestructibleType destructibleType;
    public AudioClip killSound;
    public bool selfDestruct;
    public abstract IEnumerator Kill();
}
