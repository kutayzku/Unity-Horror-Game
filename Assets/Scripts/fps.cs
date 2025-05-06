using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class fps : MonoBehaviour
{
    public TMP_Text fpsText;

    [SerializeField] private float _hudRefreshRate = 0.5f;
    public float _fps;
    private float _timer;

    private void Update()
    {
        if (Time.unscaledTime > _timer)
        {
            _fps = (int)(1f / Time.unscaledDeltaTime);
            fpsText.text = "FPS: " + _fps;
            _timer = Time.unscaledTime + _hudRefreshRate;
        }
    }
}
