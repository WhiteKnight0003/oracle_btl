using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Oracle.Util
{
	public class ValidateData
	{
		public bool validateEmail(string email)
		{
			string pattern = @"^[\w!#$%&'*+/=?^_`{|}~-]+(?:\.[\w!#$%&'*+/=?^_`{|}~-]+)*@(?:[\w](?:[\w-]*[\w])?\.)+[\w](?:[\w-]*[\w])?$";
			if (Regex.IsMatch(email, pattern))
				return true;
			return false;
		}

		public bool validatePhone(string phone)
		{
			// Mẫu này kiểm tra số điện thoại Việt Nam (10 chữ số, bắt đầu bằng 0)
			string pattern = @"^(0[3|5|7|8|9])+([0-9]{8})$";

			return Regex.IsMatch(phone, pattern);
		}
	}
}
