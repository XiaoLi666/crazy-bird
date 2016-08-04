using UnityEngine;
using System.Collections;

public class CGameStateTutorialMenu : CGameStateBase {
	public CGameStateTutorialMenu() {
		PreState ();
	}

	override public void Update () {
		if (Input.GetMouseButtonDown (0) || Input.GetKeyDown("space")) {
			CGameManager.Instance.UpdateState (new CGameStateGame());
		}
	}

	override public void PreState() {
		CUIController.Instance.m_tutorialMenu.SetActive (true);
	}

	override public void PostState() {
		CUIController.Instance.m_tutorialMenu.SetActive (false);
	}
}
