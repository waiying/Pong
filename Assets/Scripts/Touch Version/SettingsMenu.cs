using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SettingsMenu : MonoBehaviour {

	public static bool visited;

	public Text diffText;
	public Button diff_right;
	public Button diff_left;
	public static int diff_press = 0;
	Vector3 temp1;
	int flag1 = 0;

	public Text winScoreText;
	public Button win_right;
	public Button win_left;
	public static int win_press = 3;
	Vector3 temp;
	int flag = 0;

	public Text musicText;
	public Button music_right;
	public Button music_left;
	public static int music_press = 1;
	public static int flag2 = music_press;
	public static bool otherMusicPlayed = false;
	public float speed = 20;
	static float num2;
	static int flag4 = 0;
	float step;
	static float num;
	static float num3;
	Vector3 temp2;

	public Button back;
	
	void Start(){
		visited = true;
		temp2 = musicText.rectTransform.position;
		temp1 = diffText.rectTransform.position;
		temp = winScoreText.rectTransform.position;
		diffText = diffText.GetComponent<Text> ();
		diff_right = diff_right.GetComponent<Button> ();
		diff_left = diff_left.GetComponent<Button> ();
		win_right = win_right.GetComponent<Button> ();
		win_left = win_left.GetComponent<Button> ();
		music_right = music_right.GetComponent<Button> ();
		music_left = music_left.GetComponent<Button> ();
	}

	void FixedUpdate () {
		if (diff_press == 0) {
			if (flag1 == 1){
				temp1.x = diffText.rectTransform.position.x - 10;
				diffText.rectTransform.position = temp1;
				flag1 = 0;
			}
			diffText.text = "Easy";
		} else if (diff_press == 1 && flag1 == 0) {
			temp1.x = diffText.rectTransform.position.x + 10;
			diffText.rectTransform.position = temp1;
			diffText.text = "Med";
			flag1 = 1;
		} else if (diff_press == 2) {
			if (flag1 == 1){
				temp1.x = diffText.rectTransform.position.x - 10;
				diffText.rectTransform.position = temp1;
				flag1 = 0;
			}
			diffText.text = "Hard";
		}
	
		if (win_press >= 3 && win_press <= 50) {
			if (win_press > 9 && flag == 0){
				temp.x = winScoreText.rectTransform.position.x - 11;
				winScoreText.rectTransform.position = temp;
				flag = 1;
			}
			else if (win_press <= 9 && flag == 1) {
				temp.x = winScoreText.rectTransform.position.x + 11;
				winScoreText.rectTransform.position = temp;
				flag = 0;
			}
			winScoreText.text = "" + win_press;
		}

		step = speed * Time.fixedDeltaTime;
		if (music_press == 1) {
			musicText.text = "Another Way - Psykick";
			if (flag4 == 0) {
				musicText.rectTransform.position = temp2;
				num = musicText.rectTransform.position.x + 1;
				num3 = musicText.rectTransform.position.x; 
				flag4 = 1;
			}
			if (num > num3-250){
				musicText.rectTransform.Translate(-step, 0, 0);
				num = musicText.rectTransform.position.x;
			}
			else if (num <= num3-250) {
				musicText.rectTransform.Translate(step, 0, 0);
				num2 = musicText.rectTransform.position.x;
				if (num2 > temp2.x) {
					num = musicText.rectTransform.position.x;
				}
			}
		}

		else if (music_press == 2) {
			musicText.text = "Sunday - cdk";
			musicText.rectTransform.position = temp2;
			musicText.rectTransform.position = new Vector3(musicText.rectTransform.position.x + 13, musicText.rectTransform.position.y, 0);
			/*if (flag4 == 1){
				musicText.rectTransform.position = temp2;
				num = musicText.rectTransform.position.x + 1;
				num3 = musicText.rectTransform.position.x; 
				flag4 = 0;
			}
			if (num > num3-100){
				musicText.rectTransform.Translate(-step, 0, 0);
				num = musicText.rectTransform.position.x;
			}
			else if (num <= num3-100) {
				musicText.rectTransform.Translate(step, 0, 0);
				num2 = musicText.rectTransform.position.x;
				if (num2 > temp2.x) {
					num = musicText.rectTransform.position.x;
				}
			}*/
		}

		else if (music_press == 3) {
			musicText.text = "Severe Tire Damage - Kevin MacLeod";
			if (flag4 == 1) {
				musicText.rectTransform.position = temp2;
				num = musicText.rectTransform.position.x + 1;
				num3 = musicText.rectTransform.position.x; 
				flag4 = 0;
			}
			if (num > num3-600){
				musicText.rectTransform.Translate(-step, 0, 0);
				num = musicText.rectTransform.position.x;
			}
			else if (num <= num3-600) {
				musicText.rectTransform.Translate(step, 0, 0);
				num2 = musicText.rectTransform.position.x;
				if (num2 > temp2.x) {
					num = musicText.rectTransform.position.x;
				}
			}
		}

		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKey (KeyCode.Escape)) {
				Application.LoadLevel(1);
			}
		}
	}
		
	public void DiffRight () {
		if (diff_press < 2){
			diff_press += 1;
		}
	}

	public void DiffLeft (){
		if (diff_press > 0) {
			diff_press -= 1;
		}
	}

	public void WinRight () {
		if (win_press < 50) {
			win_press += 1;
		}
	}

	public void WinLeft() {
		if (win_press > 3) {
			win_press -= 1;
		}
	}

	public void MusicRight() {
		if (music_press < 3) {
			music_press += 1;
			flag2 = music_press;
		}
	}

	public void MusicLeft() {
		if (music_press > 1) {
			music_press -= 1;
			flag2 = music_press;
		}
	}

	public void BackPress() {
		Application.LoadLevel (1);
	}
}
