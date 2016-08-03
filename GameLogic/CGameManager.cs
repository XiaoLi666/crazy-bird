using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CGameManager : MonoBehaviour {

	// Public members:

	public GameObject m_mainmenu;
	public GameObject m_tutorialMenu;
	public GameObject m_scoreMenu;

	public GameObject m_player;
	public GameObject m_pipes;

	// Private members:

	private bool m_isPlayerDead = false;
	private static CGameManager m_instance;
	private CGameState m_gameState = null;

	public CGameState GameState {
		get {
			return m_gameState;
		}
	}

	public bool IsPlayerDead {
		set {
			m_isPlayerDead = value;
		}
	}

	public static CGameManager Instance {
		get {
			return m_instance;
		}
	}

	public void ActiveInGameObject(bool is_active) {
		m_player.SetActive(is_active);
		m_pipes.SetActive(is_active);
	}

	void Awake() {
		if (!m_instance) {
			m_instance = this;
		}
	}

	// Use this for initialization
	void Start() {
		m_gameState = new CGameState();
		m_gameState.CurrentState = CGameStateType.GameState.STATE_MainMenu;

		m_player.SetActive (false);
		m_pipes.SetActive (false);
	}

	// Update is called once per frame
	void Update() {
		m_gameState.UpdateState ();

		if (m_isPlayerDead) {
			// Restart ();
			CGameManager.Instance.GameState.CurrentState = CGameStateType.GameState.STATE_ScoreMenu;
		}
	}

	public void Restart () {
		SceneManager.LoadScene("CrazyBird");
	}
}
