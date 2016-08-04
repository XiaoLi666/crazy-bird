using UnityEngine;
using System.Collections;

public class CGameStateScoreMenu : CGameStateBase {
	public CGameStateScoreMenu() {
		PreState ();
	}

	override public void Update () {
		// TODO: update the content of the score menu
	}

	override public void PreState() {
		CUIController.Instance.m_scoreMenu.SetActive (true);
	}

	override public void PostState() {
		CUIController.Instance.m_scoreMenu.SetActive (false);
	}
}
