using UnityEngine;
using System.Collections;

public class m2 : MonoBehaviour {

	public static GameObject music2;
	
	// Update is called once per frame
	void Update () {
		music2 = GameObject.Find ("cdk - Sunday");
		DontDestroyOnLoad (music2);
		if (SettingsMenu.music_press == 2 && SettingsMenu.flag2 == 2) {
			/*if (SettingsMenu.otherMusicPlayed == false){
				Destroy(GameObject.FindGameObjectWithTag ("Original"));
			}*/
			if (m1.music1.GetComponent<AudioSource>().isPlaying){
				m1.music1.GetComponent<AudioSource>().Stop ();
			}
			else if (m3.music3.GetComponent<AudioSource>().isPlaying){
				m3.music3.GetComponent<AudioSource>().Stop ();
			}
			music2.GetComponent<AudioSource>().Play();
			SettingsMenu.flag2 = 0;
			SettingsMenu.otherMusicPlayed = true;
			//DontDestroyOnLoad (music2);
		}
	}

}
