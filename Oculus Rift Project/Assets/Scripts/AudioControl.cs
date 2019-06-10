using UnityEngine;
using System.Linq;

public class AudioControl : MonoBehaviour
{
    [SerializeField]
    private AudioData[] data;

    public AudioData FindAudioSourceByName(string name)
    {
        return data.First(element => element.Name == name);
    }
}
