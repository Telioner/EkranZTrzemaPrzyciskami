using System.Collections.Generic;
using UnityEngine;

public class RandomSoundPlayer : MonoBehaviour
{
	[SerializeField] AudioClip[] soundsToDraw;

	private AudioSource audioSource;

	private void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	List<int> activeSoundIndexes = new List<int>();

	public void ActivateSound(int soundIndex)
	{
		activeSoundIndexes.Add(soundIndex);
	}
	public void DeactivateSound(int soundIndex)
	{
		activeSoundIndexes.Remove(soundIndex);
	}

	public bool IsThereASoundToPlay()
	{
		return (activeSoundIndexes.Count > 0);
	}

	public void PlayRandomSound()
	{
		audioSource.PlayOneShot(soundsToDraw[ChooseIndexOfTheSoundToPlayAtRandom()]);
	}

	private int ChooseIndexOfTheSoundToPlayAtRandom()
	{
		var random = new System.Random();
		int randomIndex = random.Next(activeSoundIndexes.Count);
		int indexOfSoundToPlay = (activeSoundIndexes[randomIndex]);
		return indexOfSoundToPlay;
	}
}
