using UnityEngine;

public class FidgetCircleParticle : MonoBehaviour {

    public ParticleSystem explosionFX;

    void Start()
    {
        ParticleSystem.ShapeModule shapeModule = explosionFX.shape;
        shapeModule.radius = Screen.width / 3.85f;
        explosionFX.Play();
    }

}