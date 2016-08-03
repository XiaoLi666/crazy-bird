using UnityEngine;
using System.Collections;

public class CUIScoreMenuController : CUIController {

	public void OnClick_MenuBtn() {
		CGameManager.Instance.Restart ();
		CGameManager.Instance.GameState.CurrentState = CGameStateType.GameState.STATE_MainMenu;
	}

	public void OnClick_OKBtn() {
		CGameManager.Instance.Restart ();
		CGameManager.Instance.GameState.CurrentState = CGameStateType.GameState.STATE_TutorialMenu;
	}
}
