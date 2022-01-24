using System;
namespace CasperFun.Models
{
    public class UserModel
    {
        public string Account { get; set; }
        public string LogTime { get; set; }
        public string Balance { get; set; }
        public TransactionModel LastTransaction { get; set; }
        
    }
}
