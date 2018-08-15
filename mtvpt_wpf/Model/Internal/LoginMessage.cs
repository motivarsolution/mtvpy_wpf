using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtvpt_wpf.Model.Internal
{
    public class LoginMessage
    {
        private zAccountDetailModel _zAccountDetailModel;

        public zAccountDetailModel zAccountDetailModel
        {
            get { return _zAccountDetailModel; }
            set { _zAccountDetailModel = value; }
        }

        private ReturnStatusModel _returnStatusModel;

        public ReturnStatusModel returnStatusModel
        {
            get { return _returnStatusModel; }
            set { _returnStatusModel = value; }
        }
       
    }
}
