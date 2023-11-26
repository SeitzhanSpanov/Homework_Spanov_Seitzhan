using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlendTreeSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _slider.onValueChanged.AddListener(delegate { OnSliderValueChanged(); });
    }

    void OnSliderValueChanged()
    {
        _animator.SetFloat("Blend", _slider.value);
    }
}
