using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
	[Serializable]
	public class Executable_Limb : IExecutable
	{
		public IInstigator instigator;
		public Limb limb;

		public Executable_Limb(IInstigator instigator, Limb limb)
		{
			this.instigator = instigator;
			this.limb = limb;
		}

		public string Name => limb.Name;

		public void Execute()
		{
			Debug.Log($"{instigator} attacked, {limb.Name}");
		}
	}
}
