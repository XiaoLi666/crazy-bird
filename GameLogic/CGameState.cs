using UnityEngine;
using System.Collections;

public class CGameState {
	private CGameStateType.GameState m_currentGameState;
	public CGameStateType.GameState CurrentState {
		get {
			return m_currentGameState;
		}
		set {
			m_currentGameState = value;
			UpdateStateContent();
		}
	}

	public void UpdateState() {
		switch (m_currentGameState) {
		case CGameStateType.GameState.STATE_MainMenu:
			break;
		case CGameStateType.GameState.STATE_TutorialMenu:
			if (Input.GetMouseButtonDown (0) || Input.GetKeyDown("space")) {
				CurrentState = CGameStateType.GameState.STATE_Game;
			}
			break;
		case CGameStateType.GameState.STATE_Game:
			break;
		case CGameStateType.GameState.STATE_ScoreMenu:
			break;
		}
	}

	private void UpdateStateContent() {
		CGameManager.Instance.m_mainmenu.SetActive (false);
		CGameManager.Instance.m_tutorialMenu.SetActive (false);
		CGameManager.Instance.m_scoreMenu.SetActive (false);
		CGameManager.Instance.ActiveInGameObject (false);

		Debug.Log (m_currentGameState);

		switch (m_currentGameState) {
		case CGameStateType.GameState.STATE_MainMenu:
			CGameManager.Instance.m_mainmenu.SetActive(true);
			break;
		case CGameStateType.GameState.STATE_TutorialMenu:
			CGameManager.Instance.m_tutorialMenu.SetActive(true);
			break;
		case CGameStateType.GameState.STATE_Game:
			CGameManager.Instance.ActiveInGameObject (true);
			break;
		case CGameStateType.GameState.STATE_ScoreMenu:
			CGameManager.Instance.m_scoreMenu.SetActive(true);
			break;
		}
	}
}
