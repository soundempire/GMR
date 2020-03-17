using GMR.DAL.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace GMR.DAL.Context
{
    internal class DBInitializer : CreateDatabaseIfNotExists<GMRContext>
    {
        protected override void Seed(GMRContext context)
        {
            var admin = new Person() { FirstName = "admin", LastName = "admin", Company = "admin", Country = "Беларусь", ID = 1, Phone = "123123123123" };
            var abrazumovaPerson = new Person() { FirstName = "Л.Б.", LastName = "Абразумова", Company = "ИП", Country = "Беларусь", ID = 2, Phone = "123123123123" };
            var avdejPerson = new Person() { FirstName = "М.Г.", LastName = "Авдей", Company = "ИП", Country = "Беларусь", ID = 3, Phone = "123123123123" };

            context.Persons.AddRange(new List<Person>() { abrazumovaPerson, admin, avdejPerson });

            var adminPassword = new Password() { ID = 1, Person = admin, Login = "admin", Value = "admin", LastUpdated = DateTime.Now, PersonID = 1 };
            var abrazumovaPassword = new Password() { ID = 2, Person = abrazumovaPerson, Login = "p1", Value = "Абразумова", LastUpdated = DateTime.Now, PersonID = 2 };
            var avdejPassword = new Password() { ID = 3, Person = avdejPerson, Login = "p2", Value = "Авдей", LastUpdated = DateTime.Now, PersonID = 3 };

            context.Passwords.AddRange(new List<Password>() { adminPassword, abrazumovaPassword, avdejPassword });

            var abrazumovaContractor = new Contractor() { ID = 1, Name = $"{abrazumovaPerson.LastName} {abrazumovaPerson.FirstName}", PersonID = abrazumovaPerson.ID, Person = abrazumovaPerson, ContractorID = "М1" };
            var avdejContractor = new Contractor() { ID = 2, Name = $"{avdejPerson.LastName} {avdejPerson.FirstName}", PersonID = avdejPerson.ID, Person = avdejPerson, ContractorID = "Н31" };
            var adminContractor1 = new Contractor() { ID = 3, Name = "Apple", PersonID = admin.ID, Person = admin, ContractorID = "A1" };
            var adminContractor2 = new Contractor() { ID = 4, Name = "Google", PersonID = admin.ID, Person = admin, ContractorID = "A2" };
            var adminContractor3 = new Contractor() { ID = 5, Name = "Amazon", PersonID = admin.ID, Person = admin, ContractorID = "A3" };

            context.Contractors.AddRange(new List<Contractor>() { abrazumovaContractor, avdejContractor, adminContractor1, adminContractor2, adminContractor3 });

            var abrazumovaTransaction = new Transaction() { ID = 1, Contractor = abrazumovaContractor, ContractorID = abrazumovaContractor.ID, Currency = 2.17, Price = 0.28, Date = DateTime.Parse("10.01.2019") };
            var avdejTransaction = new Transaction() { ID = 2, Contractor = avdejContractor, ContractorID = avdejContractor.ID, Currency = 2.17, Price = 1219.29, Date = DateTime.Parse("11.01.2019") };
            var avdejTransaction2 = new Transaction() { ID = 3, Contractor = avdejContractor, ContractorID = avdejContractor.ID, Currency = 1.17, Price = 129.29, Date = DateTime.Parse("11.01.2019") };

            var adminTransaction1 = new Transaction() { ID = 4, Contractor = adminContractor1, ContractorID = adminContractor1.ID, Currency = 1.17, Price = 129.29, Date = DateTime.Parse("11.01.2019") };
            var adminTransaction2 = new Transaction() { ID = 5, Contractor = adminContractor1, ContractorID = adminContractor1.ID, Currency = 1.17, Price = 129.29, Date = DateTime.Parse("11.01.2019") };
            var adminTransaction3 = new Transaction() { ID = 6, Contractor = adminContractor2, ContractorID = adminContractor2.ID, Currency = 1.17, Price = 129.29, Date = DateTime.Parse("11.01.2019") };


            context.Transactions.AddRange(new List<Transaction>() { abrazumovaTransaction, avdejTransaction, avdejTransaction2, adminTransaction1, adminTransaction2, adminTransaction3 });

            context.SaveChanges();
        }
    }
}
