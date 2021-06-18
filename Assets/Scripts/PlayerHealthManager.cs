using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {
    public int _PlayerMaxHealth;
    public int _PlayerHealth;
    public int _PlayerLives;
    // Use this for initialization
    void Start () {
        _PlayerHealth = _PlayerMaxHealth;
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    public void Damage(int _damageAmount)
    {
        //when a player gets hit by an object, reduce his life, if lifes are less than 1, game over
        _PlayerHealth -= _damageAmount;

        if (_PlayerHealth <= 0 && _PlayerLives > 0)
        {
            _PlayerLives--;
            _PlayerHealth = 50;
            if (_PlayerLives <= 0)
            {
                //player dead
                gameObject.SetActive(false);
            }
        }
    }
}
