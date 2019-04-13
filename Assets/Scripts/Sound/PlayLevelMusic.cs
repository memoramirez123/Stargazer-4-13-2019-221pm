using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayLevelMusic : MonoBehaviour {

	int newLevelIndex = 0;
	int oldLevelIndex = 0;

	void Start() {
		FindObjectOfType<AudioManager>().Play("MenuMusic");
		newLevelIndex = 0;
		oldLevelIndex = 0;
	}

	// Update is called once per frame
	void Update () {
		newLevelIndex = SceneManager.GetActiveScene().buildIndex;
		if(newLevelIndex != oldLevelIndex){
			Debug.Log("Level Has Changed");
			ChangeLevelSong(oldLevelIndex, newLevelIndex);
		}
		oldLevelIndex = newLevelIndex;
	}

	void DetectSeasonChange(){
		
	}

	void ChangeLevelSong(int oldIndex, int newIndex){
		// MenuMusic
		if(newIndex == 0){
			FindObjectOfType<AudioManager>().Stop("SpringMusic");
			FindObjectOfType<AudioManager>().Stop("FallMusic");
			FindObjectOfType<AudioManager>().Stop("WinterMusic");
			FindObjectOfType<AudioManager>().Stop("SummerMusic");
			FindObjectOfType<AudioManager>().Play("MenuMusic");
		}
		// Spring Music
		if(newIndex == 1 || newIndex == 2 || newIndex == 3 || newIndex == 4){
			FindObjectOfType<AudioManager>().Stop("MenuMusic");
			FindObjectOfType<AudioManager>().Stop("FallMusic");
			FindObjectOfType<AudioManager>().Stop("WinterMusic");
			FindObjectOfType<AudioManager>().Stop("SummerMusic");
			FindObjectOfType<AudioManager>().Play("SpringMusic");
		}

		// Summer Music
		if(newIndex == 5 || newIndex == 6 || newIndex == 7 || newIndex == 8){
			FindObjectOfType<AudioManager>().Stop("MenuMusic");
			FindObjectOfType<AudioManager>().Stop("WinterMusic");
			FindObjectOfType<AudioManager>().Stop("SpringMusic");
			FindObjectOfType<AudioManager>().Stop("FallMusic");
			FindObjectOfType<AudioManager>().Play("SummerMusic");
		}

		// Fall Music
		if(newIndex == 9 || newIndex == 10 || newIndex == 11 || newIndex == 12){
			FindObjectOfType<AudioManager>().Stop("MenuMusic");
			FindObjectOfType<AudioManager>().Stop("WinterMusic");
			FindObjectOfType<AudioManager>().Stop("SpringMusic");
			FindObjectOfType<AudioManager>().Stop("SummerMusic");
			FindObjectOfType<AudioManager>().Play("FallMusic");
		}

		// Winter Music
		if(newIndex == 13 || newIndex == 14 || newIndex == 15 || newIndex == 16){
			FindObjectOfType<AudioManager>().Stop("FallMusic");
			FindObjectOfType<AudioManager>().Stop("MenuMusic");
			FindObjectOfType<AudioManager>().Stop("SpringMusic");
			FindObjectOfType<AudioManager>().Stop("SummerMusic");
			FindObjectOfType<AudioManager>().Play("WinterMusic");
		}
	}
}
