using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFX_Slider : MonoBehaviour {


	public Slider SfxSlider;
	public AudioSource Button_Click_sound;

	
	// Update is called once per frame
	void Update () {
		Button_Click_sound.volume = SfxSlider.value;	
	}
}
