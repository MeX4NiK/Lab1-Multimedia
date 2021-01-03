using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace Generate
{
    public partial class FFmpeg
    {
        public class CRF
        {
            /// <summary>
            /// CRF Arguments
            /// </summary>
            /// <remarks>
            /// Is the same as 1 Pass Arguments
            /// </remarks>
            public static String Arguments()
            {
                return _1_Pass.Arguments();
            }
        }
    }
}
