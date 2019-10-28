using System;
using System.Collections.Generic;
using System.Text;
using Flee;
using Flee.PublicTypes;

namespace Kiddy.Common
{
    public class Areanator
    {
        public double sumArea(string dimension, string userParameter)
        {

            List<int> num = new List<int>();
            if (!string.IsNullOrEmpty(userParameter))
            {
                string[] splitUser = userParameter.Split('|');

                foreach (var item in splitUser)
                {
                    num.Add(Convert.ToInt32(item));
                }
            }

            Double result = 0;
            // Define the context of our expression
            ExpressionContext context = new ExpressionContext();
            // Allow the expression to use all static public methods of System.Math
            context.Imports.AddType(typeof(Math));


            context.Variables["a"] = num[0];
            context.Variables["b"] = num[1];
            if (num[2] != default(int))
            {
                context.Variables["h"] = num[2];
            }

            IGenericExpression<double> eGeneric = context.CompileGeneric<double>(dimension);
            try
            {
                result = eGeneric.Evaluate();
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        //public int Area(string shapeName, int num1, int num2, int num3)
        //{
        //    return 0;
        //}
    }
}
