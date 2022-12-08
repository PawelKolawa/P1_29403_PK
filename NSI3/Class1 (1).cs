using Calculator.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KalkulatorTest.UnitTests
{
    public class KalkulatorTest
    {
        [Fact]
        public void sprawdzaniedodawania() 
        {
            //arrange
            var kalkulator = new Program();
            //act
            double wynik = kalkulator.dodawanie(1, 2);
            //assert
            Assert.Equal(3, wynik);
        }

        [Fact]
        public void sprawdzanieodejmowania()
        {
            //arrange
            var kalkulator = new Program();
            //act
            double wynik = kalkulator.odejmowanie(5, 2);
            //assert
            Assert.Equal(3, wynik);
        }

        [Fact]
        public void sprawdzaniemnozenia()
        {
            //arrange
            var kalkulator = new Program();
            //act
            double wynik = kalkulator.mnozenie(3, 2);
            //assert
            Assert.Equal(6, wynik);
        }

        [Fact]
        public void sprawdzaniedzielenia()
        {
            //arrange
            var kalkulator = new Program();
            //act
            double wynik = kalkulator.dzielenie(6, 2);
            //assert
            Assert.Equal(3, wynik);
        }

        [Fact]
        public void sprawdzanieresztazdzielenia()
        {
            //arrange
            var kalkulator = new Program();
            //act
            double wynik = kalkulator.reszta_z_dzielenia(9, 2);
            //assert
            Assert.Equal(1, wynik);
        }

        [Fact]
        public void sprawdzaniepotegowania()
        {
            //arrange
            var kalkulator = new Program();
            //act
            double wynik = kalkulator.potega(2, 3);
            //assert
            Assert.Equal(8, wynik);
        }
    }
}
