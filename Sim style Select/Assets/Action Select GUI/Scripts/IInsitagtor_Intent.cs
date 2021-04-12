using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
	public interface IInsitagtor_Intent
	{
		void Execute(ref List<IExecutable> executables);
	}
}
