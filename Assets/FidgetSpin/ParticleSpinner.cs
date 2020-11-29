using UnityEngine;

public class ParticleSpinner : MonoBehaviour {

    public ParticleSystem explosionFX1;

    void Start () {
        transform.position = new Vector3(Screen.width / 2, Screen.height / 2, 0.0f);
        ParticleSystem.ShapeModule shapeModule = explosionFX1.shape;
        shapeModule.radius = Screen.height;
        explosionFX1.Play();
    }

}