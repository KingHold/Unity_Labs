using UnityEngine;

public class Emmit : MonoBehaviour, IStrategy
{
    [SerializeField] int particlesCount;
    public void Perform(Transform obj)
    {
        obj.GetComponent<Performer>().SetStrategy(this);
        ParticleSystem particles = obj.GetComponent<ParticleSystem>();
        ParticleSystem.Burst burst = particles.emission.GetBurst(0);
        burst.count = particlesCount;
        particles.emission.SetBurst(0, burst);
        particles.Play();
    }
}
