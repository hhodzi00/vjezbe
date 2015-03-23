using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using  walletproject5;

namespace Walletproject5Test
{
    [TestClass]
    public class WalletTest
    {
        [TestMethod]
        public void TestEmptyWalletReturnsZero()
        {
            var wallet = new Wallet();

            Assert.AreEqual
            (
                0,
                wallet.GetCurrencyValue("HRK"),
                "Empty wallet should return 0"
            );
        }
        [TestMethod]
        public void TestSingleItemWalletGetCurrency()
        {
            var wallet = new Wallet();

            wallet.AddCurrencyValue("HRK", 100);


            Assert.AreEqual
               (
                   100,
                   wallet.GetCurrencyValue("HRK"),
                   "Single item wallet sahould return previously added"
               );


        }



        [TestMethod]
        public void TestMultipleSameCurrencyWalletGetCurrency()
        {
            var wallet = new Wallet();

            wallet.AddCurrencyValue("HRK", 100);
            wallet.AddCurrencyValue("HRK", 50);

            Assert.AreEqual
               (
                   150,
                   wallet.GetCurrencyValue("HRK"),
                   "should aggregate added values"
               );


        }



        [TestMethod]
        [ExpectedException(typeof (InvalidProgramException))]
        public void TestAddCurrencyCrashesIfFormatLengthInvalid()
        {
            var wallet = new Wallet();

            wallet.AddCurrencyValue("HR", 100);
        }







    }
}
