using UnityEngine;
using System.Collections;

public class MoreGamesButton : ButtonHelper 
{
    [SerializeField]
    string URL = "https://play.google.com/store/search?q=derm%20tnout&hl=en";

	override public void OnClicked()
	{
        Application.OpenURL(URL);
		print ("OnClicked : " + gameObject.name);
        //#if APPADVISORY_ADS
        //AdsManager.instance.ShowRewardedVideo ((bool success) => {
        //    print("add your own code here if you want to offer something to the player");
        //});
        //#endif
	}
}
