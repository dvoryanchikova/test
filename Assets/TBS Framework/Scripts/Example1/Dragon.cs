using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MyUnit {

	protected override void Defend(Unit other, int damage)
	{
		var realDamage = damage;
		if (other is Hero)
			realDamage *= 2;//Hero deals double damage to Dragon.

		base.Defend(other, realDamage);
	}
}
