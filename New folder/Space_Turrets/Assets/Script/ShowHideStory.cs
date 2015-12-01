using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowHideStory : MonoBehaviour {
	
	public Text StoryText;
	
	void Start ()
	{
		StoryText.text = "";
	}
	
	public void ShowStory()
	{
		StoryText.text = "Bulwark of Bernal\n\nHumanity has colonized the planet of Bernal" +
			"\nand must defend their new home from the Wroegaks";
	}
	
	public void HideStory()
	{
		StoryText.text = "";
	}
}
