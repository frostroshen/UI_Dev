﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_move : MonoBehaviour {

	public GameObject player;

	void Update () {
		transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, -10f);
	}
}
