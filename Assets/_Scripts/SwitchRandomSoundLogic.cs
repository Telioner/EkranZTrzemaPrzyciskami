using UnityEngine;

public class SwitchRandomSoundLogic : MonoBehaviour
{
	[SerializeField] int indexOfSoundToActivateOrDeactivate;
	[SerializeField] bool isSwitchActiveAtStart;

	RandomSoundPlayer randomSoundPlayer;
	MenuManager menuManager;
	private bool isSwitchActive;

	private void Start()
	{
		isSwitchActive = isSwitchActiveAtStart;
		randomSoundPlayer = GameObject.Find("Random Sound Player").GetComponent<RandomSoundPlayer>();
		menuManager = GameObject.Find("Menu Manager").GetComponent<MenuManager>();

		//Position switch image at start
		if (isSwitchActive)
		{
			RotateSwitch();
			randomSoundPlayer.ActivateSound(indexOfSoundToActivateOrDeactivate);
		}
	}

	public void SwitchTheSwitch()
	{
		menuManager.PlaySwitchSound();
		RotateSwitch();
		if (isSwitchActive)
		{
			randomSoundPlayer.DeactivateSound(indexOfSoundToActivateOrDeactivate);
			isSwitchActive = false;
		}
		else
		{
			randomSoundPlayer.ActivateSound(indexOfSoundToActivateOrDeactivate);
			isSwitchActive = true;
		}
	}

	private void RotateSwitch()
	{
		this.gameObject.transform.Rotate(new Vector3(0f, 0f, 180f));
	}
}
