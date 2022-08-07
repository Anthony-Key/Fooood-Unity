using System.Collections;
using DefaultNamespace;
using UnityEngine;

[System.Serializable]
public abstract class GameItem : MonoBehaviour
{
    public GameObject destructibleMesh;
    public ParticleSystem particleSystem;
    public Gradient killGradient;
    public float timeToKill;
    public DestructibleType destructibleType;
    public AudioClip killSound;
    public abstract IEnumerator Kill();
}
