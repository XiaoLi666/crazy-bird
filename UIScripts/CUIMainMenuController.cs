using UnityEngine;
using System.Collections;

public class CUIMainMenuController : CUIController {
	public void OnClick_StartBtn() {
		CGameManager.Instance.GameState.CurrentState = CGameStateType.GameState.STATE_TutorialMenu;
	}
}
