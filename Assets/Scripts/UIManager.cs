using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Image _healthBarGreen;
    public Image _healthBarOrange;
    public Image _healthBarRed;
    public PlayerHealthManager _playerHealth;
    public float _tempHealth;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //_healthBar.fillAmount = _playerHealth._PlayerMaxHealth / 10;
        if (_playerHealth._PlayerHealth >= 50)
        { 
        _healthBarGreen.fillAmount = (float)_playerHealth._PlayerHealth /100;
        }
        if (_playerHealth._PlayerHealth < 50)
        {
            _healthBarOrange.enabled = true;
            _healthBarGreen.enabled = false;
           _healthBarOrange.fillAmount = (float)_playerHealth._PlayerHealth / 100;
        }
         if (_playerHealth._PlayerHealth < 20 )
        {
            _healthBarOrange.enabled = false;
            _healthBarRed.enabled = true;
            _healthBarRed.fillAmount = (float)_playerHealth._PlayerHealth / 100;
        }

    }
}
