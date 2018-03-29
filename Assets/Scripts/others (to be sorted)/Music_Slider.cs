using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music_Slider : MonoBehaviour {

	public Slider MusicSlider;
	public AudioSource Main_menu_theme;
	
	// Update is called once per frame
	void Update () {
		Main_menu_theme.volume = MusicSlider.value;
	}
}
