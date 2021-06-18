using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour {
    private Image _HealthBarImage;
    public int _healthBarValue;
    public Player _player;

    // Use this for initialization
    void Start () {
        _player = FindObjectOfType<Player>();
        _HealthBarImage = FindObjectOfType<Image>();
        _healthBarValue = _player._PlayerHealth;
    }
	
	// Update is called once per frame
	void Update () {
        _healthBarValue = _player._PlayerHealth;
        _HealthBarImage.fillAmount = _player._PlayerHealth;
    }
}
