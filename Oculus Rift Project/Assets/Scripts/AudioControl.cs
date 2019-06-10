using UnityEngine;
using System.Linq;

public class AudioControl : MonoBehaviour
{
    [SerializeField]
    private AudioData[] data;

    public AudioData FindAudioClipByName(string name)
    {
        return data.First(element => element.Name == name);
    }
}
