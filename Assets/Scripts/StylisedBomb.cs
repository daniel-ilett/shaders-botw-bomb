using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class StylisedBomb : MonoBehaviour
{
    [SerializeField] private CameraController cameraController;
    [SerializeField] private VisualEffect sparkParticles;

    private void Awake()
    {
        sparkParticles.Stop();
    }

    private void StartExplosion()
    {
        sparkParticles.Play();
        cameraController.StartExplosion();
    }
}
