using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
	internal abstract class BankAccount: BankingService
	{
		double balance;

		public double Balance { get; protected set; }

		public BankAccount(Owner owner) : base(owner)//azért kell külön metódus hogy mindig hozzá lehessen adni balancet
		{

		}

		public void Deposit(double amount)
		{
			balance += amount;
		}

		public abstract bool Withdraw(double amount);//ha van sok osztályom és van bennük közös, akkor az abstarktokra mindig rávesz hogy implementáljam a többibe

		public BankCard NewCard(string cardNumber)
		{
			return new BankCard(this.Owner, Balance, cardNumber);
		}
	}
}
