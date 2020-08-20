using UnityEngine;
using TMPro;

public class PopUpLogic : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI popUpText;

	private Animator popUpAnimator;
	private bool isPopedIn = false;

	public void Start()
	{
		popUpAnimator = GetComponent<Animator>();
	}

	public void TryToPopInWithText(string text)
	{
		if (!isPopedIn)
		{
			popUpText.SetText(text);
			popUpAnimator.SetTrigger("PopIn");
			isPopedIn = true;
		}
	}

	public void TryToPopOut()
	{
		if (isPopedIn)
		{
			popUpAnimator.SetTrigger("PopOut");
			isPopedIn = false;
		}
	}
}
