using UnityEngine;
using System.Collections;

public class m1 : MonoBehaviour {

	public static GameObject music1;
	static int flag8 = 0;
	// Update is called once per frame
	void Start() {
		music1 = GameObject.Find ("Another Way - PsychKick");
		if (flag8 == 0) {
			flag8 = 1;
			music1.GetComponent<AudioSource> ().Play ();
			DontDestroyOnLoad (music1);
		}
	}
	void Update () {
		
		if (SettingsMenu.music_press == 1 && SettingsMenu.flag2 == 1 && SettingsMenu.otherMusicPlayed == true) {
			m2.music2.GetComponent<AudioSource>().Stop (); 
			music1.GetComponent<AudioSource>().Play ();
			SettingsMenu.flag2 = 0;
			//music1.name = "MUSIC1";
			//DontDestroyOnLoad(music1);
		}
	}
}
