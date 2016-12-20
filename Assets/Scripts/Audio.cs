using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {

	GameObject music;
	//public static AudioSource music1;
	//public static AudioSource playing;
	//public GameObject i;

	void Awake () {
		music = GameObject.FindGameObjectWithTag ("Original");
		//i = GameObject.Find ("Tag");
		music.GetComponent<AudioSource>().Play();
		DontDestroyOnLoad (music);
	}
}
