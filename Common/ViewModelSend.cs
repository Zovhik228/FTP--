﻿using System;

namespace Common
{
    public class ViewModelSend
    {
        public string Message { get; set; }
        public int Id { get; set; }
        public ViewModelSend(string message, int Id)
        {
            this.Message = message;
            this.Id = Id;
        }
    }
}