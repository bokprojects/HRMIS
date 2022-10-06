using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMISver1.Helpers
{
    public class utility
    {
        public int isInteger(string Value)
        {
			int result = -1;
			try
			{
				result = int.Parse(Value);
			}
			catch (Exception ex)
			{

				throw;
			}
			return result;
        }
    }
}
