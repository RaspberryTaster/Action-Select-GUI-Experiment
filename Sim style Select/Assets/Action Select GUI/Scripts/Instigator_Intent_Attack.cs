using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
	public class Instigator_Intent_Attack : IInsitagtor_Intent
	{
		private IInstigator instigator;
		private Body interactor_Body;

		public Instigator_Intent_Attack(IInstigator instigator, Body interactor_Body)
		{
			this.instigator = instigator;
			this.interactor_Body = interactor_Body;
		}

		public void Execute(ref List<IExecutable> executables)
		{
			for (int I = 0; I < interactor_Body.limbs.Length; I++)
			{
				executables.Add(new Executable_Limb(instigator, interactor_Body.limbs[I]));
			}
		}
	}
}
