using UnityEngine;
using System.Collections;

public class CGameStateMainMenu : CGameStateBase {
	public CGameStateMainMenu() {
		PreState ();
	}

	override public void Update () {
	}

	override public void PreState() {
		CUIController.Instance.m_mainMenu.SetActive (true);
	}

	override public void PostState() {
		CUIController.Instance.m_mainMenu.SetActive (false);
	}
}
