using UnityEngine;
using System.Collections;

public class CGameStateGame : CGameStateBase {
	public CGameStateGame() {
		PreState ();
	}

	override public void Update () {
		if (CGameManager.Instance.IsPlayerDead) {
			CGameManager.Instance.UpdateState (new CGameStateScoreMenu());
		}
	}

	override public void PreState() {
		CGameManager.Instance.ActiveInGameObject (true);
	}

	override public void PostState() {
		CGameManager.Instance.ActiveInGameObject (false);
	}
}
