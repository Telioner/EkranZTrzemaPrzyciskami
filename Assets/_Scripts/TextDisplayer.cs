using UnityEngine;

public class TextDisplayer : MonoBehaviour
{
	[SerializeField] GameObject textObject;

	public void DisplyTextForGivenAmountOfSecondsIfPossible(int seconds)
	{
		if (!textObject.activeInHierarchy)
		{
			textObject.SetActive(true);
			Invoke("DeactivateGameobject", seconds);
		}
	}

	private void DeactivateGameobject()
	{
		textObject.SetActive(false);
	}
}
