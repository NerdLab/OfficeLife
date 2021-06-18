using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    { 
		
	}

      private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Enemy")
        {
            if (collision.transform.parent != null)
            {

            }
        }
        else if (collision.tag == "Player")
        {
            int randomDamage = Random.Range(1, 50);
            Player player = collision.GetComponent<Player>();
         
            if (player != null)
            {
                collision.gameObject.GetComponent<PlayerHealthManager>().Damage(randomDamage);
            }
        }
    }
}
