using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personnel.Data
{
    public class APIResult
    {

        //------------------------------------------
        public bool Success { get; set; }
        public bool Warning { get; set; }
        public string Message { get; set; }
        public long Miliseconds { get; set; }
        public object Data { get; set; }
        //----------------------------------------------------
        public void SetSuccess(string Message)
        {
            this.Success = true;
            this.Message = Message;
        }
        //----------------------------------------------------
        public void SetWarning(string Message)
        {
            this.Success = true;
            this.Warning = true;
            this.Message = Message;
        }
        //----------------------------------------------------
        public void SetSuccess(string Message, object Data)
        {
            this.Success = true;
            this.Message = Message;
            this.Data = Data;
        }//----------------------------------------------------
        public void SetFailure()
        {
            this.Message = "Personnel System Error. Please Contact Support.";
        }
        //----------------------------------------------------
        public void SetFailure(string Message)
        {
            this.Message = Message;
        }
        //----------------------------------------------------
        public void SetFailure(string Message, object Data)
        {
            this.Success = false;

            this.Message = Message;
            this.Data = Data;
        }
        //----------------------------------------------------
    }
}
