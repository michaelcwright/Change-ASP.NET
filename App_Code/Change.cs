using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Web.UI.WebControls;

public class Change : System.Web.UI.Page
{
      //private variables
      private int hundredz = 100;
      private int fiftyz = 50;
      private int twentyz = 20;
      private int tez = 10;
      private int fivez = 5;
      private int onez = 1;

      private double quarter = 0.25;
      private double dime = 0.10;
      private double nickel = 0.05;
      private double penny = 0.01;

      private int hundreds = 0;
      private int fifty = 0;
      private int twenty = 0;
      private int ten = 0;
      private int five = 0;
      private int one = 0;
    
      private int quarters = 0;
      private int dimes = 0;
      private int nickels = 0;
      private int pennys = 0;

      //set accessor
      public void setValues(double amount) {
          int changeCash = Convert.ToInt32(amount);
          double changeCoinz = amount - changeCash;
          //process cash amount          
          hundreds = (int)(changeCash / hundredz);
          fifty = (int)((changeCash % hundredz) / fiftyz);
          twenty = (int)(((changeCash % hundredz) % fiftyz) / twentyz);
          ten = (int)((((changeCash % hundredz) % fiftyz) % twentyz) / tez);
          five = (int)(((((changeCash % hundredz) % fiftyz) % twentyz) % tez) / fivez);
          one = (int)((((((changeCash % hundredz) % fiftyz) % twentyz) % tez) % fivez) / onez);
          //process coin amount
          quarters = (int)(changeCoinz / quarter);
          dimes = (int)((changeCoinz % quarter) / dime);
          nickels = (int)(((changeCoinz % quarter) % dime) / nickel);
          pennys = (int)((((changeCoinz % quarter) % dime) % nickel) / penny);
      }

      //get accessor
      public string getValues()
      {
          //passes string results to variable
         string resultz= "<div id='changeCashDiv'><p><b>Cash Change</b></p><p><b>100</b> = "
                       + hundreds + "</p><b>50</b> = "
                           + fifty + "</p><b>20</b> = "
                               + twenty + "</p><b>10</b> = "
                                   + ten + "</p><b>5</b> = "
                                       + five + "</p><b>1</b> = "
                                           + one + "</p></div><div id='changeCoinsDiv'><p><b>Coin Change</b></p><p><b>Quarters</b> = "
              + quarters + "</p><b>Dimes</b> = "
                  + dimes + "</p><b>Nickels</b> = "
                      + nickels + "</p><b>Pennies</b> = "
                          + pennys + "</p></div>";
          //returns variable
         return resultz;
  
      }
}
