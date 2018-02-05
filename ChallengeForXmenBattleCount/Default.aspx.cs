using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";

            int smallest = 0;
            int largest = 0;



            for (int i = 0; i < names.Length; i++)
            {
                // This should show the xmen with the most and least. 
                //if (numbers[i] == numbers.Min())  ---  this doesn't work . returns incorrect index .. have to use the variable
                if (numbers[i] < numbers[smallest])
                {
                    smallest = i;
                }
                //if (numbers[i] == numbers.Max())  ---  this doesn't work . returns incorrect index .. have to use the variable
                if (numbers[i] > numbers[largest])
                {
                    largest = i;                    
                }
                result = String.Format(" Most Battles belong to:{0} Value: {1}<br/>", names[largest], numbers[largest]);
                result += String.Format(" Least Battles belong to:{0} Value: {1}", names[smallest], numbers[smallest]);

                resultLabel.Text = result;
            }
        }
    }
}