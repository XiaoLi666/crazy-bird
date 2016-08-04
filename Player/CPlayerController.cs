using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CPlayerController : MonoBehaviour {

	// Public member:

	public GameObject m_player;
	public GameObject m_scoreText;
	[Range(0f,10f)]
	public float m_upVelocityRange;
	[Range(0f,20f)]
	public float m_upForceRange;

	// Private member:

	private Rigidbody2D m_playerRigidBody;
	private Transform m_playerTransform;
	private Vector2 m_upVelocity;

	// Use this for initialization
	void Start () {
		m_playerRigidBody = m_player.GetComponent<Rigidbody2D>();
		m_playerTransform = m_player.transform;
		m_upVelocity = new Vector2(0f, m_upVelocityRange);
	}
	
	// Update is called once per frame
	void Update () {
		if (m_player == null)
			return;

		// TODO: to use the command design pattern
		if (Input.GetKeyDown ("space") || Input.GetMouseButtonDown(0)) {
			m_playerRigidBody.velocity = m_upVelocity;
			m_playerRigidBody.AddForce(m_playerTransform.up.normalized * m_upForceRange, ForceMode2D.Force);
		}
	}

	// Check the collision detection with the ground
	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag=="ground" || other.gameObject.tag == "pipes") {
			CGameManager.Instance.IsPlayerDead = true;
		}

		if (other.gameObject.tag == "score_checker") {
			other.gameObject.SetActive (false);
			CGameManager.Instance.Score ++;
		}
	}
}
