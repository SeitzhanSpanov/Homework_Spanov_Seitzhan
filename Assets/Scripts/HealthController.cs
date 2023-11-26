using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [SerializeField] private Slider _healthbar;
    [SerializeField] private float _health;
    [SerializeField] private float _fillSpeed;
    private float _healthPersents;

    private void Start()
    {
        _healthPersents = _health / 100;
    }
    public void MakeDamage(float damage)
    {
        if (_health > 0)

        {
            _health -= damage;
        }
        else
        {
            _health = 0;
        }
        _healthPersents = _health / 100;
    }
    private void Update()
    {
        _healthbar.value = Mathf.Lerp(_healthbar.value, _healthPersents, Time.deltaTime * _fillSpeed);
    }
}
