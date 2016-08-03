using UnityEngine;
using System.Collections;

public class CMovingObjectsController : MonoBehaviour {

	public GameObject m_startWaypoint = null;
	public GameObject m_endWaypoint = null;
	[Range(0.0f, 0.05f)]
	public float m_moveSpeed;

	private float m_threshold = 0f;
	private int m_moveDir = -1;

	protected virtual void Start() {
		m_moveSpeed *= m_moveDir;
		m_threshold = Mathf.Abs(m_moveSpeed);
	}

	protected bool ReachEndWaypoint(GameObject obj) {
		float x_move_delta = (m_endWaypoint.transform.position - obj.transform.position).x;
		if (Mathf.Abs(x_move_delta) <= m_threshold) {
			return true;
		}
		return false;
	}

	protected void Move(GameObject obj_to_move) {
		obj_to_move.transform.position += new Vector3 (m_moveSpeed, 0f, 0f);
	}
}
