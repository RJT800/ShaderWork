using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class RimLightDisco : MonoBehaviour
{
    [SerializeField, Range(0.01f,10)]
    float _speed = 1;
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (_renderer == null || _renderer.material == null)
            return;
        float value = (Mathf.Sin(Time.time * 2) + _speed) / 2;
        _renderer.material.SetFloat("_RimPower", value * 9 + 1);
        _renderer.material.SetFloat("_RimIntensity", value * 10);
    }
}
