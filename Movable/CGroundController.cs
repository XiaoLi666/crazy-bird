using UnityEngine;
using System.Collections;

public class CGroundController : CMovingObjectsController {

	public GameObject[] m_grounds;

	void Update() {
		for (int i = 0; i < m_grounds.Length; ++i) {
			GameObject ground = m_grounds[i];
			Move (ground);
			if (ReachEndWaypoint (ground)) {
				ground.transform.position = m_startWaypoint.transform.position;
			}
		}
	}
}
