using UnityEngine;
using System.Collections;

public class CUIController : MonoBehaviour {

	// Public members:

	public GameObject m_mainMenu;
	public GameObject m_tutorialMenu;
	public GameObject m_scoreMenu;
	public GameObject m_inGameUI;

	public Sprite m_medalNormal;
	public Sprite m_medalCopper;
	public Sprite m_medalSilver;
	public Sprite m_medalGold;
	public GameObject m_medal;

	public GameObject m_scoreMenuMyScore;
	public GameObject m_scoreMenuBestScore;

	// Private members:

	private static CUIController m_instance;

	// Methods:

	void Awake() {
		if (!m_instance) {
			m_instance = this;
		}
	}

	public static CUIController Instance {
		get {
			return m_instance;
		}
	}

	// Button Click Callback functions:

	public void OnClick_MainMenu_StartButton() {
		CGameManager.Instance.UpdateState(new CGameStateTutorialMenu());
	}

	public void OnClick_ScoreMenu_OKButton() {
		CGameManager.Instance.UpdateState (new CGameStateMainMenu());
		CGameManager.Instance.Restart ();
	}
}
