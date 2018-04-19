using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		this.transform.Translate(0.0f, 0.0f, 0.5f);
	}

	void OnCollisionEnter(Collision collision){

		if (collision.collider.gameObject.tag == "Enemy") {

			//Carga el prefab de una explosion
            GameObject explosionmars = GameObject.Instantiate (Resources.Load ("prefab/ExplosionMars")as GameObject);

			//Muevo la explosion a la posicion donde esta la nave
			explosionmars.transform.position = collision.collider.gameObject.transform.position;

			//Eliminamos el enemigo
			Destroy (collision.collider.gameObject);

			// Destruimos el misisl 
			Destroy (this.gameObject);
		}

		if (collision.collider.gameObject.tag == "JupiterAlien") {
			GameObject explosionjupiter = GameObject.Instantiate (Resources.Load ("prefab/ExplosionJupiter")as GameObject);

			explosionjupiter.transform.position = collision.collider.gameObject.transform.position;

			Destroy (collision.collider.gameObject);
			Destroy (this.gameObject);


		}	}
}