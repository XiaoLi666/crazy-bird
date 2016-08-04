using UnityEngine;
using System.Collections;

public abstract class CGameStateBase {
	protected CGameStateBase() {}
	abstract public void Update ();
	abstract public void PreState ();
	abstract public void PostState ();
}
