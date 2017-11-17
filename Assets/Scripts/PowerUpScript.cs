using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour {

    HUDScrpit hud;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") ;
        {
            hud = GameObject.Find("Main Camera").GetComponent<HUDScrpit>();
            hud.IncreaseScore(10);
            Destroy(this.gameObject);
        }
    }
}
