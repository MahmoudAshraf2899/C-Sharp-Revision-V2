using lists_And_Dictionaries.Services;
using System;
using System.Collections.Generic;

namespace lists_And_Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Both List And Dictionary allocated at Heap Memory (Refernce Type)
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);


            List<Contract_Installments> monthlyInstallmentObj = new List<Contract_Installments>();
            monthlyInstallmentObj.Add(new Contract_Installments()
            {
                contractId = 1,
                date = DateTime.Now.Date,
                installmentType = "قسط شهري",
                instalmmentValue = 10000
            });
            monthlyInstallmentObj.Add(new Contract_Installments()
            {
                contractId = 2,
                date = DateTime.Now.Date,
                installmentType = "قسط شهري",
                instalmmentValue = 5000
            });
            monthlyInstallmentObj.Add(new Contract_Installments()
            {
                contractId = 3,
                date = DateTime.Now.Date,
                installmentType = "قسط شهري",
                instalmmentValue = 10000
            });
            monthlyInstallmentObj.Add(new Contract_Installments()
            {
                contractId = 4,
                date = DateTime.Now.Date,
                installmentType = "قسط شهري",
                instalmmentValue = 1000
            });
            monthlyInstallmentObj.Add(new Contract_Installments()
            {
                contractId = 5,
                date = DateTime.Now.Date,
                installmentType = "قسط شهري",
                instalmmentValue = 2000
            });

            List<Contract_Installments> yearlyInstallmentObj = new List<Contract_Installments>();
            yearlyInstallmentObj.Add(new Contract_Installments()
            {
                contractId = 1,
                date = DateTime.Now.Date,
                installmentType = "قسط سنوي",
                instalmmentValue = 10000
            });
            yearlyInstallmentObj.Add(new Contract_Installments()
            {
                contractId = 2,
                date = DateTime.Now.Date,
                installmentType = "قسط سنوي",
                instalmmentValue = 5000
            });
            yearlyInstallmentObj.Add(new Contract_Installments()
            {
                contractId = 3,
                date = DateTime.Now.Date,
                installmentType = "قسط سنوي",
                instalmmentValue = 10000
            });
            yearlyInstallmentObj.Add(new Contract_Installments()
            {
                contractId = 4,
                date = DateTime.Now.Date,
                installmentType = "قسط سنوي",
                instalmmentValue = 1000
            });
            yearlyInstallmentObj.Add(new Contract_Installments()
            {
                contractId = 5,
                date = DateTime.Now.Date,
                installmentType = "قسط سنوي",
                instalmmentValue = 4000
            });
            Dictionary<string, List<Contract_Installments>> contractInstallmentsDictionary = new Dictionary<string, List<Contract_Installments>>();
            contractInstallmentsDictionary.Add("قسط شهري", monthlyInstallmentObj);
            contractInstallmentsDictionary.Add("قسط سنوي", yearlyInstallmentObj);
            double? totalMontlyInstallments = 0;
            double? totalYearlyInstallments = 0;
            foreach (var item in contractInstallmentsDictionary)
            {
                if (item.Key == "قسط شهري")
                {
                    foreach (var value in item.Value)
                    {
                        totalMontlyInstallments += value.instalmmentValue;
                        //Add Payment System Table Here For Procoor 
                        /* 
                         var paymentSystem = new PaymentSystem() 
                        {
                            percentage 
                        }
                         */
                    }
                }
                if(item.Key == "قسط سنوي")
                {
                    foreach (var yearValue in item.Value)
                    {
                        totalYearlyInstallments += yearValue.instalmmentValue;
                    }
                }
            }
            Console.WriteLine($"Total Montly Installments : {totalMontlyInstallments}");
            Console.WriteLine($"Total Yearly Installments : {totalYearlyInstallments}");


        }
    }
}
