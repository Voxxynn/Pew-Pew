using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponScript: MonoBehaviour {

	public Transform target;
	public GameObject weapon;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			GameObject newWeapon = Instantiate (weapon, gameObject.transform.parent);
			newWeapon.transform.localPosition = transform.localPosition + new Vector3 (0f, 0f, 2.5f);
			newWeapon.transform.rotation = Quaternion.LookRotation (target.position - transform.position);
		}
	}
}
