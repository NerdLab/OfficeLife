using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int _EnemyMaxHealth;
    public int _EnemyHealth;
    public int _EnemyLives;
    // Use this for initialization
    void Start()
    {
        _EnemyHealth = _EnemyMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DamageEnemy(int _damageAmount)
    {
        //when an ememy gets hit by an object, reduce his life, if lifes are less than 1, game over
        _EnemyHealth -= _damageAmount;

        if (_EnemyHealth <= 0 && _EnemyLives > 0)
        {
            _EnemyLives--;
            _EnemyHealth = 50;
            if (_EnemyLives <= 0)
            {
                //enemy dead
                Destroy(gameObject);
            }
        }
    }
}
