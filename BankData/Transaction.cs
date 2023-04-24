using System.Test;

namespace DOTNET_SAMPLE
{
    public class Transaction
    {
      public decimal Number { get; }
      public DateTime Date { get; }
      public string Notes { get; }
	
      public Transaction (decimal amount, DateTime date, string note)
      {
          this.amount = amount;
          this.date = date;
          this.note = note;

      }    
    }
}