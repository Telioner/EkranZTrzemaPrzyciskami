using UnityEngine;

public class MenuManager : MonoBehaviour
{
	[SerializeField] AudioClip clickSound;
	[SerializeField] AudioClip switchSound;

	private AudioSource audioSource;
	private PopUpLogic popUpLogic;
	private TextDisplayer textDisplayer;
	private RandomSoundPlayer randomSoundPlayer;

	public void Start()
	{
		audioSource = GetComponent<AudioSource>();
		popUpLogic = GameObject.Find("PopUp Box").GetComponent<PopUpLogic>();
		textDisplayer = GameObject.Find("Text Displayer").GetComponent<TextDisplayer>();
		randomSoundPlayer = GameObject.Find("Random Sound Player").GetComponent<RandomSoundPlayer>();
	}

	public void PlayClickSound()
	{
		audioSource.PlayOneShot(clickSound);
	}
	public void PlaySwitchSound()
	{
		audioSource.PlayOneShot(switchSound);
	}


	//PopUp button
	public void TryToDisplayPopUpWithText(string text)
	{
		PlayClickSound();
		popUpLogic.TryToPopInWithText(text);
	}

	//PopUp exit button
	public void TryToStopDisplayingPopUp()
	{
		PlayClickSound();
		popUpLogic.TryToPopOut();
	}

	//3 second text button
	public void TryToDisplayTextForSetAmountOfSeconds(int seconds)
	{
		PlayClickSound();
		textDisplayer.DisplyTextForGivenAmountOfSecondsIfPossible(seconds);
	}

	//Random sound button
	public void PlayRandomSoundFromSelctedSounds()
	{
		if (randomSoundPlayer.IsThereASoundToPlay())
		{
			randomSoundPlayer.PlayRandomSound();
		}
		else
		{
			PlayClickSound();
		}
	}
}
