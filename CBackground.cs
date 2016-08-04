using UnityEngine;
using System.Collections;

public class CBackground : MonoBehaviour {
	public GameObject m_backgroundDay;
	public GameObject m_backgroundNight;

	void Start () {
		float r_value = Random.Range(1f,3f);
		if (r_value <= 2f) {
			m_backgroundDay.SetActive (true);
		}
		else if (r_value > 2f) {
			m_backgroundNight.SetActive (true);
		}
	}
}
