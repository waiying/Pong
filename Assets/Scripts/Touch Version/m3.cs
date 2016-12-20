using UnityEngine;
using System.Collections;

public class m3 : MonoBehaviour {
	
	public static GameObject music3;
	
	// Update is called once per frame
	void Update () {
		music3 = GameObject.Find ("Severe Tire Damage");
		DontDestroyOnLoad (music3);
		if (SettingsMenu.music_press == 3 && SettingsMenu.flag2 == 3) {
			m2.music2.GetComponent<AudioSource>().Stop (); 
			music3.GetComponent<AudioSource>().Play ();
			SettingsMenu.flag2 = 0;
			//DontDestroyOnLoad(music3);
		}
	}
}
