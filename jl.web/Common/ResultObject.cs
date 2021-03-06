﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JL.Web.Common
{
    public class ResultObject<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        
        public static ResultObject<T>  Create(bool success=true,string message = "ok")
        {
            ResultObject<T> obj = new ResultObject<T>();
            obj.Success = success;
            obj.Message = message;
            return obj;
        }

        public static ResultObject<T> Succeed(T t,string message = "ok")
        {
            ResultObject<T> obj = new ResultObject<T>();
            obj.Success = true;
            obj.Message = message;
            obj.Data = t;
                
            return obj;
        }
        
    }

    public class ResultObject
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public static ResultObject Create(bool success = true, string message = "ok")
        {
            ResultObject obj = new ResultObject();
            obj.Success = success;
            obj.Message = message;
            return obj;
        }

        public static ResultObject Succeed(string message = "ok")
        {
            ResultObject obj = new ResultObject();
            obj.Success = true;
            obj.Message = message;
            return obj;
        }

        public static ResultObject Failed(string message = "opertion failed.")
        {
            ResultObject obj = new ResultObject();
            obj.Success = false;
            obj.Message = message;
            return obj;
        }

    }
}