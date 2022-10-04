using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Fields__Constats
{
    // class modifiers public, internal (default)
    public class employee
    {

        //fields -> (access modifier) (dataType)  (name)
        //AccessModifiers public private protected
        //constant access is from the class
        //const must be initilized
        public static double TAX = 0.03;
        public string FName;
        public string LName;
        public double wage;
        public double LoggedHours;

        private double calculate()
        {
            return wage * LoggedHours;
        }
        private double  calculateTAX()=>calculate()*TAX;

        private double calculateNet() => calculate() - calculateTAX();

        public string printslipt() {
            return $"\nfirst name : {FName} \n" +
                    $"last name : {LName} \n" +
                    $"wage : {wage} \n" +
                    $"logged hours : {LoggedHours} \n" +
                    "----------------------------------------------------------\n" +
                    $"salary : {calculate()}$\n" +
                    $"Dejuctable tax ({TAX * 100}%)tax amount : {calculateTAX()}\n" +
                    $"net salary : {calculateNet()}\n";
        }

    }
}
