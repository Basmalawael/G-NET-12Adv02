using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12Adv02.OnlineStore
{
    /*

    // I used Func<Product, string> because we are performing a transformation, 
    // taking a Product object and returning its data as a formatted string.

    public class TransformPro
    {                                                                                 //in      //out 
        public static List<string> TransformProducts (List<Product> products ,  Func<Product , string> transformation)
        {
            List<string> result = new List<string>();

            foreach (var product in products)
            {
                string transformedItem = transformation(product);
                result.Add(transformedItem);
            }
            return result;
        }
    } */
}
