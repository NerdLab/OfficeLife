using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour {

    public int _damageToGive;
    public GameObject _BloodBurst;
    public Transform _DamagePoint;

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Enemy")
        { 
                collision.gameObject.GetComponent<EnemyHealthManager>().DamageEnemy(_damageToGive);
                Instantiate(_BloodBurst, _DamagePoint.position, _DamagePoint.rotation);
        }
    }
}
