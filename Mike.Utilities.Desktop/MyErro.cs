using System;
using System.Collections.Generic;
using System.Data;

namespace Mike.Utilities.Desktop
{
    public static class MyErro
    {
        public static Exception MyException(string erroMessage = "Erro não foi atribuido")
        {
            throw new Exception(erroMessage);
        }
        public static CustomException MyCustomException(string erroMessage = "Erro não foi atribuido")
        {
            throw new CustomException(erroMessage);
        }
        public static string MyTernaryExceptionString(string erroMessage = "Erro não foi atribuido")
        {
            try
            {               
                throw new CustomException(erroMessage);
            }
            catch (Exception Erro)
            {

                throw new CustomException(Erro.Message);
            }

        }        
        //public static string MyTernaryCustomExceptionString(string erroMessage = "Erro não foi atribuido")
        //{
        //    try
        //    {
        //        throw new CustomException(erroMessage);
        //    }
        //    catch (CustomException Erro)
        //    {

        //        throw new CustomException(Erro.Message);
        //    }

        //}
    }
}
