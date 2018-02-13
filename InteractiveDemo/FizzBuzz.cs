using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveDemo {
    public class Test {
        public static List<string> FizzBuzz(int length) {
            
            return Enumerable
                .Range(1, length)
                .Select(x => {
                    switch (x) {
                        case int n when n % 5 == 0 && n % 3 == 0:
                            return "FizzBuzz";
                        case int n when n % 5 == 0:
                            return "Fizz";
                        case int n when n % 3 == 0:
                            return "Buzz";
                        case int n:
                            return n.ToString();
                    }
                }).ToList();
        }
    }
}
