using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
	internal abstract class BankingService //abstarct - hogy ne lehessenközvetlen példányosítani, program.cs-ben ne lehessen példányt létrehozni
	{
		Owner owner;
		public Owner Owner { get; }
		protected BankingService(Owner owner)
		{
			this.owner = owner;
		}

	}
}
