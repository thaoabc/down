﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnShowLeaderboard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Button>().onClick.AddListener(() =>
		{
			GooglePlayServicesScript.ShowLeaderboardUI();
		});	
	}
}
