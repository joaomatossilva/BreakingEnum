using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakingEnum.Common;

namespace BreakingEnum.Helper
{
    public class StatusHelper
    {
        public static bool IsActive(string statusText)
        {
            var status = (StatusEnum) Enum.Parse(typeof (StatusEnum), statusText);
            var isActive = status == StatusEnum.Active;
            return isActive;
        }
    }
}
