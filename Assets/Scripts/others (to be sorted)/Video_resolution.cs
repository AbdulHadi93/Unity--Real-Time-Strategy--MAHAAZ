using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Video_resolution: MonoBehaviour {

	public void ChangeResolution(float level)
	{
		switch((int)level)
		{
		case 0:
			Screen.SetResolution(640, 480, true);
		break;

		case 1:
			Screen.SetResolution(800, 600, true);
		break;

		case 2:
			Screen.SetResolution(1024, 768, true);
		break;

		case 3:
			Screen.SetResolution(1920, 1080, true);
		break;
				
		}
	}

}
	