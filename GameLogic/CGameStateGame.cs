using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CGameStateGame : CGameStateBase {
	private GameObject m_scoreText = null;

	public CGameStateGame() {
		PreState ();
	}

	public void UpdateScore(int score) {
		Text score_text = m_scoreText.GetComponent<Text>();
		score_text.text = score.ToString ();

		if (score == 99) {
			// TODO: WIN!!
		}
	}

	override public void Update () {
		if (CGameManager.Instance.IsPlayerDead) {
			CGameManager.Instance.UpdateState (new CGameStateScoreMenu());
		}
	}

	override public void PreState() {
		CGameManager.Instance.ActiveInGameObject (true);
		CUIController.Instance.m_inGameUI.SetActive (true);
		m_scoreText = CUIController.Instance.m_inGameUI.transform.GetChild(0).gameObject;
	}

	override public void PostState() {
		CGameManager.Instance.ActiveInGameObject (false);
		CUIController.Instance.m_inGameUI.SetActive (false);
	}
}
