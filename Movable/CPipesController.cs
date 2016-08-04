using UnityEngine;
using System.Collections;

public class CPipesController : CMovingObjectsController {

	public GameObject[] m_pipeGroups;
	public GameObject[] m_scoreChecker;
	public float m_lowerBound;
	public float m_upperBound;

	protected override void Start() {
		base.Start();
		for (int i = 0; i < m_pipeGroups.Length; ++i) {
			RandomizePipePosition(m_pipeGroups[i]);
		}
	}

	void Update() {
		for (int i = 0; i < m_pipeGroups.Length; ++i) {
			GameObject pipe_group = m_pipeGroups[i];
			Move(pipe_group);
			if (ReachEndWaypoint (pipe_group)) {
				pipe_group.transform.position = m_startWaypoint.transform.position;
				RandomizePipePosition(pipe_group);

				// Reset score checker
				for (int j = 0; j < m_scoreChecker.Length; ++j) {
					m_scoreChecker [i].SetActive (true);
				}
			}
		}
	}

	void RandomizePipePosition(GameObject pipe_group) {
		pipe_group.transform.position = new Vector2 (pipe_group.transform.position.x, Random.Range(m_lowerBound, m_upperBound));
	}
}
