using UnityEngine;
using System.Collections;

public class PlayButton : ButtonHelper 
{
	override public void OnClicked()
	{
		print ("OnClicked : " + gameObject.name);
		menuManager.GoToGame();
		RemoveListener();
	}
}
