using UnityEngine;
using System.Collections;

public class ButtonCloseSetting : ButtonHelper 
{
    [SerializeField] MenuLogic _home_screen;
    [SerializeField] RectTransform _playscreen;

	override public void OnClicked()
	{
        if (gameObject.name != "BackButton_ToHome")
        {
            print("OnClicked : " + gameObject.name);
            menuManager.CloseSettings();
            RemoveListener();
        }
        else
        {
            _home_screen.transform.localScale = Vector3.one;
            _home_screen.gameObject.SetActive(true);
            _home_screen.Title.gameObject.SetActive(true);
            _home_screen.FirstTimeMenu.gameObject.SetActive(true);
            _home_screen.GameOverMenu.gameObject.SetActive(false);

            _home_screen.M.text = "គិ";
            _home_screen.A.text = "ត";
            _home_screen.T.text = "េល";
            _home_screen.H.text = "ខ";

            _home_screen.G.text = "+";
            _home_screen.A_.text = "-";
            _home_screen.M_.text = "X";
            _home_screen.E.text = "%";


            _playscreen.gameObject.SetActive(false);
        }
	}
}