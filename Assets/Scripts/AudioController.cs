using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private static AudioController _instance;

    public static AudioController Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<AudioController>();
            }

            return _instance;
        }
    }
    
    [NonReorderable]
    [SerializeField] private List<AudioSet> audioSet = new List<AudioSet>();

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void PlayAudio(DestructibleType type, AudioClip clip)
    {
        audioSet.ForEach(audio =>
        {
            if (type == audio.type)
            {
                audio.source.clip = clip;
                audio.source.Play();
            }
        });
    }
}

[System.Serializable]
public class AudioSet
{
    public AudioSource source;
    public DestructibleType type;
}
