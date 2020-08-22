﻿namespace Exceptional.Playground
{
    using System;
    using System.IO;

    public class Demonstration
    {
        #region methods

        public void Test01()
        {
            // There is no documentation for the exception. 
            throw new InvalidOperationException("Message"); // BAD
        }

        public void Test02()
        {
            var number = decimal.Parse("3.4");
            var file = File.Open("test", FileMode.Open);
        }

        /// <exception cref="InvalidOperationException">Condition. </exception>
        public void Test03()
        {
            // No exception is thrown so the exception documentation is invalid. 
        }

        public void Test04()
        {
            try
            {
            }
            catch (Exception) // BAD
            {
                Console.WriteLine("CATCH");
            }
        }

        /// <exception cref="InvalidOperationException">Condition. </exception>
        public void Test05()
        {
            try
            {
            }
            catch (OperationCanceledException exception) // OK
            {
                throw new InvalidOperationException("Message"); // BAD
            }
        }

        #endregion
    }
}