using UnityEngine;
using System.Collections;

public class ButtonFacebook : MonoBehaviour {

	public void OnClicked(){

        string facebookApp = "https://www.facebook.com/dermtnoutkhmer/";
        string facebookAddress = "https://www.facebook.com/dermtnoutkhmer/";

		float startTime;
		startTime = Time.timeSinceLevelLoad;

		//open the facebook app
		Application.OpenURL(facebookApp);

		if (Time.timeSinceLevelLoad - startTime <= 1f)
		{
			//fail. Open safari.
			Application.OpenURL(facebookAddress);
		}
	}

}
