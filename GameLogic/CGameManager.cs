using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CGameManager : MonoBehaviour {

	// Public members:
	public GameObject m_player;
	public GameObject m_pipes;
	public int m_scoreToWin;

	// Private members:

	private bool m_isPlayerDead = false;
	private CGameStateBase m_state;
	private int m_score;
	private static CGameManager m_instance;

	public int Score {
		get {
			return m_score;
		}
		set {
			m_score = value;
			((CGameStateGame)GameState).UpdateScore (m_score);
		}
	}

	public CGameStateBase GameState {
		set {
			m_state = value;
		}
		get {
			return m_state;
		}
	}

	public bool IsPlayerDead {
		set {
			m_isPlayerDead = value;
		}
		get {
			return m_isPlayerDead;
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

	public void Restart () {
		SceneManager.LoadScene("CrazyBird");
	}

	public void UpdateState(CGameStateBase new_state) {
		if (m_state != null) {
			m_state.PostState ();
		}
		GameState = new_state;
	}

	// Private Methods:

	void Awake() {
		if (!m_instance) {
			m_instance = this;
		}
	}

	// Use this for initialization
	void Start() {
		UpdateState (new CGameStateMainMenu ());
		m_score = 0;
	}

	// Update is called once per frame
	void Update() {
		// m_gameState.UpdateState ();
		m_state.Update();
	}
}
