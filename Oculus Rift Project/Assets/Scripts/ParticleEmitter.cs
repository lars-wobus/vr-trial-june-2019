using UnityEngine;

public class ParticleEmitter : MonoBehaviour, IParticleEmitter
{
    [SerializeField]
    private ParticleSystem system;

    public void StartShooting()
    {
        system.Play(true);
    }

    public void StopShooting()
    {
        system.Stop(true);
    }

#if UNITY_EDITOR

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartShooting();
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            StopShooting();
        }
    }
#endif
}
