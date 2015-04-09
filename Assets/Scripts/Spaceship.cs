﻿using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Spaceship : MonoBehaviour 
{
	public float speed;

	public float shotDelay;

	public GameObject bullet;

	public bool canShot;

	public void Shot (Transform origin)
	{
		Instantiate (bullet, origin.position, origin.rotation);
	}

	public void Move (Vector2 direction)
	{
		rigidbody2D.velocity = direction * speed;
	}

}
