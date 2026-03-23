using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ToggleParticleController : MonoBehaviour
{
    public KeyCode toggleKey = KeyCode.Space;

    public List<ParticleSystem> particles;
    public List<ParticleSystem> initializationParticles;

    bool isPlaying = true;

    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            if (isPlaying)
            {
                for (int i = 0; i < particles.Count; i++)
                {
                    particles[i].Stop();
                }
                isPlaying = false;
            }
            else
            {
                for (int i = 0; i < particles.Count; i++)
                {
                    if (i < initializationParticles.Count && initializationParticles[i] != null)
                        initializationParticles[i].Play();
                    particles[i].Play();
                }
                isPlaying = true;
            }
        }
    }
}
