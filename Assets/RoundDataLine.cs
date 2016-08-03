﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RoundDataLine : MonoBehaviour {

    public Text heroField;
    public Text characterField;
    public Text title;

	void Start () {
        title.text = "";
        heroField.text = "";
        characterField.text = "";
	}
    public void Init(int roundID, int heroScore, int characterScore)
    {
        if (roundID > 0)
            title.text = "ROUND " + roundID;
        else
            title.text = "";

        heroField.text = heroScore.ToString();
        characterField.text = characterScore.ToString();
    }
}
