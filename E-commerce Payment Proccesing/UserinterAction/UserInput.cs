using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_Payment_Proccesing.UserinterAction;

public interface IUserInputClass
{
    string UserInput();
}

public class UserInputClass : IUserInputClass
{
    public string UserInput()
    {
        return Console.ReadLine() ?? string.Empty;
    }

}
