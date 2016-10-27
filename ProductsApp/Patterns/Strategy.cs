using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Patterns
{
    public interface SuperInterface
    {
        int Add(int a, int b);
        int Subtrack(int a, int b);
    }
    public class Strategy
    {

        public int AddSomeNumbers(SuperInterface myObj, int A, int B)
        {
            return myObj.Add(A, B);
        }

    }
}