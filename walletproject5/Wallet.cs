using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace walletproject5
{
   public class Wallet
    {
       public Wallet()
       {
           this.dictionary= new Dictionary<string,float>();
       }

       public void AddCurrencyValue(string currency, float value)
       {
           CheckCurrencyFormat(currency);


           if(this.dictionary.ContainsKey(currency))
           {
            this.dictionary[currency] += value;
           }
           else 

           this.dictionary.Add(currency, value);
       }

       private void CheckCurrencyFormat(string currency)
       {
           if (currency == null) { throw new InvalidProgramException("currency can not be null"); }

           if (currency.Length != 3)
           {
            throw new InvalidProgramException("currency mudt be of length 3");
           }

           if (currency.ToUpper() != currency)
           {
               throw new InvalidProgramException("currency must be upper case");
           }

       }

       public float GetCurrencyValue( string currency)
       {
           return this.dictionary.ContainsKey(currency)
               ? this.dictionary[currency]
               : 0;
       }


       public string GetState()
       {
           var state = "";

           for (var i = 0; i < this.dictionary.Keys.Count; i++)
           {
               var key = this.dictionary.Keys.ElementAt(i); //HRK
               var value = this.dictionary[key];        //100
           }

           return state;
       }


       private Dictionary<string, float> dictionary;
    }
}
