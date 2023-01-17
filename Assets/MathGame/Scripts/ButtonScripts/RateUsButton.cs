using UnityEngine;
using System.Collections;

public class RateUsButton : ButtonHelper 
{
    [SerializeField] string _line_rating;
	override public void OnClicked()
	{
		print ("OnClicked : " + gameObject.name);
        Application.OpenURL(_line_rating);
	}
}
