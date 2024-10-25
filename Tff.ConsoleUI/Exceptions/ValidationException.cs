using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tff.ConsoleUI.Exceptions;

public class ValidationException(string message): Exception(message)
{
}
