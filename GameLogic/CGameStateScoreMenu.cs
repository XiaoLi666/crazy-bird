using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CGameStateScoreMenu : CGameStateBase {
	public CGameStateScoreMenu() {
		PreState ();
	}

	override public void Update () {
	}

	override public void PreState() {
		CUIController.Instance.m_scoreMenu.SetActive (true);

		int final_score = CGameManager.Instance.Score;

		// TODO: how to determine the score range
		CUIController.Instance.m_medal.transform.GetComponent<UnityEngine.UI.Image>().sprite = CUIController.Instance.m_medalNormal;
//		switch (final_score) {
//		case 1:
//			CUIController.Instance.m_medal.transform.GetComponent<UnityEngine.UI.Image>().sprite = CUIController.Instance.m_medalNormal;
//			break;
//		case 2:
//			CUIController.Instance.m_medal.transform.GetComponent<UnityEngine.UI.Image>().sprite = CUIController.Instance.m_medalCopper;
//			break;
//		case 3:
//			CUIController.Instance.m_medal.transform.GetComponent<UnityEngine.UI.Image>().sprite = CUIController.Instance.m_medalSilver;
//			break;
//		case 4:
//			CUIController.Instance.m_medal.transform.GetComponent<UnityEngine.UI.Image>().sprite = CUIController.Instance.m_medalGold;
//			break;
//		}

		Text my_score = CUIController.Instance.m_scoreMenuMyScore.GetComponent<Text>();
		my_score.text = final_score.ToString ();

		// TODO: for highest score, need to use the local database to manage the player data (E.g. just a text file to save the highest score)
	}

	override public void PostState() {
		CUIController.Instance.m_scoreMenu.SetActive (false);
	}
}
